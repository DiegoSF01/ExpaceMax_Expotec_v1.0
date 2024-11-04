using ArenaDeBatalha.ObjetosDoJogo;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Threading;
using System.Windows.Input;
using System.Linq;
using System.Threading.Tasks;
using System.Drawing.Drawing2D;
using System.Runtime.InteropServices;
using System.Drawing.Text;
using System.Security.Policy;
using MySql.Data.MySqlClient;
using System.Data.SqlClient;
using Org.BouncyCastle.Asn1.Cms;

//adicionar referência para os assemblies WindowsBase.dll e Presentation.Core

namespace ArenaDeBatalha.GUI
{
    public partial class FormPrincipal : Form
    {
        private PrivateFontCollection privateFonts = new PrivateFontCollection();
        private void LoadCustomFont()
        {
            // Adicione o caminho da fonte
            privateFonts.AddFontFile(@"C:\Users\Usuario\source\repos\ExpaceMax_Expotec_v1.0\font\Micro5-Regular.ttf");
            score.Font = new Font(privateFonts.Families[0], 35, FontStyle.Regular);
        }

        DispatcherTimer gameLoopTimer { get; set; }
        DispatcherTimer enemySpawnTimer { get; set; }
        bool gameIsOver { get; set; }
        bool vitoriaIsOver { get; set; }
        bool canShoot { get; set; }
        Random random { get; set; }
        Graphics screen { get; set; }
        Bitmap screenBuffer { get; set; }
        Background background { get; set; }
        Player player { get; set; }
        GameOver gameOver { get; set; }
        Vitoria vitoria { get; set; }
        List<GameObject> gameObjects { get; set; }
        public string NomeJogador { get; set; }
        public int Pontuacao { get; set; }

        private string connectionString = "Server=localhost;Database=ranking_jogo;Uid=root;Pwd=etecjau;Port=3307;";
        private MySqlConnection conexao;

        private Timer pausaTimer;

        public FormPrincipal()
        {
            InitializeComponent();
            LoadCustomFont();
            ConectarBanco();

            pausaTimer = new Timer();
            pausaTimer.Interval = 1500;
            pausaTimer.Tick += PausaTimer_Tick;

            float scaleX = Screen.PrimaryScreen.WorkingArea.Width / 1920.0F;
            this.ClientSize = new Size((int)(775 / scaleX), (int)(572 / scaleX));
            this.screenBuffer = new Bitmap(Media.Background.Width, Media.Background.Height);
            this.screen = Graphics.FromImage(this.screenBuffer);
            this.background = new Background(this.screenBuffer.Size, this.screen);
            this.player = new Player(this.screenBuffer.Size, this.screen, gameObjects);
            this.gameOver = new GameOver(this.screenBuffer.Size, this.screen);
            this.vitoria = new Vitoria(this.screenBuffer.Size, this.screen);
            vitoriaIsOver = false;
            gameIsOver = false;
            this.gameObjects = new List<GameObject>();
            this.gameObjects.Add(background);
            this.gameObjects.Add(player);
            
            StartGame();
        }

        private void ConectarBanco()
        {
            try
            {
                conexao = new MySqlConnection(connectionString);
                conexao.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao conectar: " + ex.Message);
            }
        }

        // Fechar a conexão ao sair do formulário
        private void Formprincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (conexao != null)
            {
                conexao.Close();
            }
        }

        public void StartGame()
        {
            this.random = new Random();
            this.gameIsOver = false;
            this.vitoriaIsOver = false;
            this.gameObjects.Clear();
            this.gameObjects.Add(background);
            this.gameObjects.Add(player);
            this.player.SetStartPosition();

            this.gameLoopTimer = new DispatcherTimer(DispatcherPriority.Render);
            this.gameLoopTimer.Interval = TimeSpan.FromMilliseconds(16.6666);
            this.gameLoopTimer.Tick += GameLoop;
            this.gameLoopTimer.Start();

            this.enemySpawnTimer = new DispatcherTimer();
            this.enemySpawnTimer.Interval = TimeSpan.FromMilliseconds(1000);
            this.enemySpawnTimer.Tick += SpawnEnemy;
            this.enemySpawnTimer.Start();
        }

        private void SpawnEnemy(object sender, EventArgs e)
        {
            Point enemyPosition = new Point(this.random.Next(2, this.screenBuffer.Size.Width - 66), -62);
            Enemy enemy = new Enemy(this.screenBuffer.Size, this.screen, enemyPosition);
            this.gameObjects.Add(enemy);
        }

        private void GameLoop(object sender, EventArgs e)
        {
            if (gameIsOver)
            {
                EndGame();
                return;
            }

            if (vitoriaIsOver)
            {
                EndGameVi();
                return;
            }

            this.gameObjects.RemoveAll(x => !x.Active);

            this.ProcessControls();

            foreach (GameObject goA in this.gameObjects)
            {
                goA.UpdateObject();

                if (goA.IsOutOfBounds())
                {
                    goA.Destroy();
                    continue;
                }

                if (goA is Enemy)
                {
                    if (gameIsOver) return;

                    if (goA.IsCollidingWith(player))
                    {
                        gameIsOver = true;
                        return;
                    }

                    foreach (GameObject goB in this.gameObjects.Where(x => x is Bullet))
                    {
                        if (goA.IsCollidingWith(goB))
                        {
                            goA.Destroy();
                            goB.Destroy();

                            LimiteDePontuacao.LimitePontuacao -= 10;
                            score.Text = ControladorPontuacao.Pontuacao.ToString();

                            if (LimiteDePontuacao.LimitePontuacao > 0)
                            {
                                if (ControladorPontuacao.Pontuacao < 500)
                                {
                                    ControladorPontuacao.Pontuacao += 10;
                                }
                                else if (ControladorPontuacao.Pontuacao >= 500)
                                {
                                    ControladorPontuacao.Pontuacao += 20;
                                }
                                else if (ControladorPontuacao.Pontuacao >= 1000)
                                {
                                    ControladorPontuacao.Pontuacao += 50;
                                }
                            }
                            if (ControladorPontuacao.Pontuacao < 500)
                            {
                                ControladorPontuacao.Pontuacao += 10;
                            }
                            else if (ControladorPontuacao.Pontuacao >= 500)
                            {
                                ControladorPontuacao.Pontuacao += 50;
                            }
                            else if (ControladorPontuacao.Pontuacao >= 1000)
                            {
                                ControladorPontuacao.Pontuacao += 100;
                            }
                            else if (ControladorPontuacao.Pontuacao >= 2000)
                            {
                                ControladorPontuacao.Pontuacao += 150;
                            }
                            else if (ControladorPontuacao.Pontuacao > 500)
                            {
                                ControladorPontuacao.Pontuacao += 200;
                            }

                            if (LimiteDePontuacao.LimitePontuacao == 0)
                            {
                                vitoriaIsOver = true;
                                ControladorPontuacao.Pontuacao = 0;
                            }
                        }
                    }
                }
            }

            this.Invalidate();
        }

        private void EndGameVi()
        {
            this.gameObjects.RemoveAll(x => !(x is Background));
            this.gameLoopTimer.Stop();
            this.enemySpawnTimer.Stop();
            this.background.UpdateObject();
            this.vitoria.UpdateObject();
            Invalidate();

            pausaTimer.Start();

            ControladorPontuacao.Pontuacao = 0;
            Enemy.ResetSpeed();
            Player.ResetSpeed();
            Bullet.ResetSpeed();
        }

        private void EndGame()
        {
            this.gameObjects.RemoveAll(x => !(x is Background));
            this.gameLoopTimer.Stop();
            this.enemySpawnTimer.Stop();
            this.background.UpdateObject();
            this.gameOver.UpdateObject();
            Invalidate();

            if (!string.IsNullOrEmpty(NomeJogador))
            {
                int pontuacao = ControladorPontuacao.Pontuacao;

                InserirPontuacao(NomeJogador, pontuacao);
            }

            pausaTimer.Start();

            ControladorPontuacao.Pontuacao = 0;
            Enemy.ResetSpeed();
            Player.ResetSpeed();
            Bullet.ResetSpeed();
        }

        private void InserirPontuacao(string nome, int pontuacao)
        {
            using (MySqlConnection conexao = new BancoDeDados().AbrirConexao())
            {
                // Verifica se já existe uma pontuação para o jogador
                string query = "SELECT pontuacao FROM classificacao WHERE nome = @nome";
                using (MySqlCommand comando = new MySqlCommand(query, conexao))
                {
                    comando.Parameters.AddWithValue("@nome", nome);
                    var resultado = comando.ExecuteScalar();

                    if (resultado != null)
                    {
                        // Se existe, compara as pontuações
                        int pontuacaoExistente = Convert.ToInt32(resultado);
                        if (pontuacao > pontuacaoExistente)
                        {
                            // Se a nova pontuação for maior, atualiza
                            string updateQuery = "UPDATE classificacao SET pontuacao = @pontuacao WHERE nome = @nome";
                            using (MySqlCommand updateCommand = new MySqlCommand(updateQuery, conexao))
                            {
                                updateCommand.Parameters.AddWithValue("@pontuacao", pontuacao);
                                updateCommand.Parameters.AddWithValue("@nome", nome);
                                updateCommand.ExecuteNonQuery();
                            }
                        }
                    }
                    else
                    {
                        // Se não existe, insere uma nova entrada
                        string insertQuery = "INSERT INTO classificacao (nome, pontuacao) VALUES (@nome, @pontuacao)";
                        using (MySqlCommand insertCommand = new MySqlCommand(insertQuery, conexao))
                        {
                            insertCommand.Parameters.AddWithValue("@nome", nome);
                            insertCommand.Parameters.AddWithValue("@pontuacao", pontuacao);
                            insertCommand.ExecuteNonQuery();
                        }
                    }
                }
            }
        }


        private void ProcessControls()
        {
            if (Keyboard.IsKeyDown(Key.Left)) player.MoveLeft();
            if (Keyboard.IsKeyDown(Key.Right)) player.MoveRight();
            if (Keyboard.IsKeyDown(Key.Up)) player.MoveUp();
            if (Keyboard.IsKeyDown(Key.Down)) player.MoveDown();
            if (canShoot && Keyboard.IsKeyDown(Key.Space))
            {
                this.gameObjects.Add(player.Shoot());
                this.canShoot = false;
            }
            if (Keyboard.IsKeyUp(Key.Space))
            {
                this.canShoot = true;
            }
        }

        private void FormPrincipal_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            e.Graphics.DrawImage(screenBuffer, 0, 0);
        }

        private void FormPrincipal_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
            if (e.KeyCode == Keys.R)
            {
                this.StartGame();
            }
        }

        private void PausaTimer_Tick(object sender, EventArgs e)
        {
            // Para o timer
            pausaTimer.Stop();

            // Exibir a classificação após o tempo de pausa
            FormInicio formInicio = new FormInicio();
            formInicio.Show();
            this.Hide(); // Oculta o formulário atual
        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {
        }
    }
}
