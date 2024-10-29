using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Org.BouncyCastle.Asn1.Crmf;

namespace _231465
{
    public class Banco
    {
        //criando variaveis para conexao e consulta serão usadas em todo o projeto
        //connection responsavel pela conexao com o MySQl
        public static MySqlConnection Conexao;
        // Command  responsavel pelas instrucoes sql a serem executadas
        public static MySqlCommand Comando;
        // adapter responsavel por inserir dados em um datatable
        public static MySqlDataAdapter Adaptador;
        public static DataTable datTabela;

        public static void AbrirConexao()
        {
            try
            {
                Conexao = new MySqlConnection("server=localhost;port=3307;uid=root;pwd=etecjau");

                //Abre a conexao com o banco de dados
                Conexao.Open();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static void FecharConexao()
        {
            try
            {
                // fecha a conexao com o banco de dados
                Conexao.Close();

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static void CriarBanco()
        {
            try
            {
                AbrirConexao();
                //cria o banco
                Comando = new MySqlCommand("CREATE DATABASE IF NOT EXISTS vendas; USE vendas", Conexao);
                //executa a query no mysql (raio do workbench)
                Comando.ExecuteNonQuery();

                //cria atabela
                Comando = new MySqlCommand("CREATE TABLE IF NOT EXISTS Cidades " +
                                            "(id integer auto_increment primary key, " +
                                            "nome char(40), " +
                                            "uf char(02))", Conexao);
                Comando.ExecuteNonQuery();

                Comando = new MySqlCommand("CREATE TABLE IF NOT EXISTS Marcas " +
                                            "(id integer auto_increment primary key, " +
                                            "marca char(20))", Conexao);
                Comando.ExecuteNonQuery();
                Comando = new MySqlCommand("CREATE TABLE IF NOT EXISTS Categorias " +
                                            "(id integer auto_increment primary key, " +
                                            "categoria char(20))", Conexao);
                Comando.ExecuteNonQuery();

                //chama a funcao para fechar a conexao com o banco
                FecharConexao();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}