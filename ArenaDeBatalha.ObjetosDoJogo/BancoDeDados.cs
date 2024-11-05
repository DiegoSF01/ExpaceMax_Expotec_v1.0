using MySql.Data.MySqlClient;
using System;
using System.IO;
using System.Windows.Forms;

public class BancoDeDados
{
    private string connectionString = "Server=localhost;Database=nome_do_banco;Uid=root;Pwd=etecjau;Port=3307;";

    public MySqlConnection AbrirConexao()
    {
        MySqlConnection conexao = new MySqlConnection(connectionString);

        try
        {
            conexao.Open();
            return conexao;
        }
        catch (MySqlException ex)
        {
            MessageBox.Show("Erro ao abrir a conexão com o banco de dados: " + ex.Message);
            return null;
        }
    }

    public void FecharConexao(MySqlConnection conexao)
    {
        if (conexao != null && conexao.State == System.Data.ConnectionState.Open)
        {
            try
            {
                conexao.Close();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Erro ao fechar a conexão com o banco de dados: " + ex.Message);
            }
        }
    }

    public void ImportarBancoDeDados(string caminhoArquivoSql)
    {
        if (!File.Exists(caminhoArquivoSql))
        {
            MessageBox.Show("Arquivo SQL não encontrado.");
            return;
        }

        try
        {
            using (MySqlConnection conexao = AbrirConexao())
            {
                if (conexao == null)
                {
                    return;
                }

                string scriptSql = File.ReadAllText(caminhoArquivoSql);
                MySqlCommand comando = new MySqlCommand(scriptSql, conexao);
                comando.ExecuteNonQuery();
                MessageBox.Show("Banco de dados importado com sucesso.");
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show("Erro ao importar o banco de dados: " + ex.Message);
        }
    }
}