using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeto_mvc2023
{
    class LoginDAL
    {
        // criação de um método que consulta o banco e retorna se o
        // usuario foi encontardo ou não
        public bool GetLoginDAL(LoginDTO loginDTO)
        {
            // conectar ao banco de dados
            try
            {
                //criação da conexão
                MySqlConnection conn = UtilsDAL.GetConnection();

                if (conn.State == Connection.Open)
                {
                    string sql = $"SELECT * FROM usuarios" +
                                 $" WHERE " +
                                 $"email = '{loginDTO.Email}' " +
                                 $"AND" +
                                 $"senha = '{loginDTO.Senha}'";

                    MySqlCommand retorno = new MySqlCommand(sql, conn);

                    MySqlDataReader reader = retorno.ExecutarReader();

                    if (reader.Read())
                    {
                        return true;
                    }
                }
            }
            catch (System.Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
            return false;
        }
    }
}
