using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

public class BancoDeDados
{
    private string connectionString = "Server=localhost;Uid=root;Pwd=etecjau;Port=3307;";

    // Método para abrir a conexão
    public MySqlConnection AbrirConexao()
    {
        MySqlConnection conexao = new MySqlConnection(connectionString);
        conexao.Open();
        return conexao;
    }

    // Método para fechar a conexão (boas práticas)
    public void FecharConexao(MySqlConnection conexao)
    {
        if (conexao != null && conexao.State == System.Data.ConnectionState.Open)
        {
            conexao.Close();
        }
    }

    // Método para criar automaticamente o banco e a tabela
    public void InicializarBancoDeDados()
    {
        try
        {
            using (var conexao = AbrirConexao())
            {
                string queryCriarBanco = @"
                    CREATE DATABASE IF NOT EXISTS ranking_jogo;
                    USE ranking_jogo;
                    CREATE TABLE IF NOT EXISTS classificacao (
                        id INT AUTO_INCREMENT PRIMARY KEY,
                        nome VARCHAR(50) NOT NULL,
                        pontuacao INT NOT NULL
                    );
                ";

                using (MySqlCommand comando = new MySqlCommand(queryCriarBanco, conexao))
                {
                    comando.ExecuteNonQuery();
                }
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Erro ao inicializar o banco de dados: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
