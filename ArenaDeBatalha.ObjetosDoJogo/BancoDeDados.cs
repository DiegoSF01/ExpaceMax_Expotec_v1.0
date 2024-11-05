using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

public class BancoDeDados
{
    private string connectionString = "Server=localhost;Uid=root;Pwd=etecjau;Port=3307;";

    public MySqlConnection AbrirConexao()
    {
        MySqlConnection conexao = new MySqlConnection(connectionString);
        conexao.Open();
        return conexao;
    }

    public void FecharConexao(MySqlConnection conexao)
    {
        if (conexao != null && conexao.State == System.Data.ConnectionState.Open)
        {
            conexao.Close();
        }
    }
}
