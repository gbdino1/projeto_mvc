using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;

namespace projeto_mvc2023
{
    class LoginDAL
    {
        // criação de um método que consulta o banco e retorna se o
        // usuario foi encontardo ou não
        public bool GetLoginDAL(LoginDTO dadosLogin)
        {
            // conectar ao banco de dados
            try
            {
                //criação da conexão
                MySqlConnection conn = UtilsDAL.GetConnection();

                if (conn.State == ConnectionState.Open)
                {
                    //pequisar no bd se o usuário existe
                    string sql = $"SELECT * FROM usuarios" +
                                 $" WHERE " +
                                 $"email = '{dadosLogin.Email}' " +
                                 $"AND" +
                                 $"senha = '{dadosLogin.Senha}'";

                    MySqlCommand retorno = new MySqlCommand(sql, conn);

                    MySqlDataReader reader = retorno.ExecuteReader();

                    if (reader.Read())
                    {
                        return true;
                    }

                    return false;
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
                return false;
            }
            return false;
        }
    }
}
