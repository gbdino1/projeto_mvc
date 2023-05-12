using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeto_mvc2023
{
    class UtilsDAL
    {
        // método que realiza a conexão com o banco e retorna um 
        // tipo MysqlConnection como resposta.
        public static MySqlConnection GetConnection()
        {
            // objeto builder que contém os dados de conexão
            MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder
            {
                Server = "localhost",
                Database = "cad_usuarios",
                UserID = "root",
                Password = ""
            };
            // criar conexão
            MySqlConnection connection = new MySqlConnection(builder.ConnectionString);
            connection.Open();

            return connection;
        }
    }
}
