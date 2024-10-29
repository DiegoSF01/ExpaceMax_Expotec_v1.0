﻿using MySql.Data.MySqlClient;
using System;
using System.Data.SqlClient;
using System.Windows.Forms;

public class BancoDeDados
{
    private string connectionString = "Server=localhost;Database=ranking_jogo;Uid=root;Pwd=etecjau;Port=3307;";

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
}

