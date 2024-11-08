using System;
using System.IO;
using System.Data.SqlClient;

class Program
{
    static void Main()
    {
        // Caminho para o arquivo .sql
        string filePath = @"C:\caminho\para\seu\arquivo.sql";

        // Lê o conteúdo do arquivo .sql
        string sqlCommands = File.ReadAllText(filePath);

        // String de conexão com o banco de dados (ajuste conforme necessário)
        string connectionString = "Server=seu_servidor;Database=seu_banco_de_dados;User Id=seu_usuario;Password=sua_senha;";

        // Conectar ao banco de dados e executar os comandos SQL
        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            try
            {
                connection.Open();

                // Cria o comando SQL
                using (SqlCommand command = new SqlCommand(sqlCommands, connection))
                {
                    // Executa os comandos
                    command.ExecuteNonQuery();
                }

                Console.WriteLine("Comandos SQL executados com sucesso!");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro: {ex.Message}");
            }
        }
    }
}
