using MySql.Data.MySqlClient;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using ArenaDeBatalha.ObjetosDoJogo;

namespace ArenaDeBatalha.GUI
{
    public partial class FormClassificacao : Form
    {
        public FormClassificacao()
        {
            InitializeComponent();
            ExibirClassificacao();
        }

        private void ExibirClassificacao()
        {
            dataGridView1.Rows.Clear();
            List<(string, int)> ranking = ObterClassificacao();

            int posicao = 1;
            foreach (var (nome, pontuacao) in ranking)
            {
                dataGridView1.Rows.Add(posicao++, nome, pontuacao);
            }
        }

        private List<(string, int)> ObterClassificacao()
        {
            List<(string, int)> ranking = new List<(string, int)>();
            using (MySqlConnection conexao = new BancoDeDados().AbrirConexao())
            {
                string query = "SELECT nome, pontuacao FROM classificacao ORDER BY pontuacao DESC";
                using (MySqlCommand comando = new MySqlCommand(query, conexao))
                using (MySqlDataReader reader = comando.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        string nome = reader.GetString("nome");
                        int pontuacao = reader.GetInt32("pontuacao");
                        ranking.Add((nome, pontuacao));
                    }
                }
            }
            return ranking;
        }

        private void button1_Click(object sender, System.EventArgs e)
        {
            var jogoForm = new FormInicio();
            jogoForm.Show();
            this.Hide();
        }
    }
}
