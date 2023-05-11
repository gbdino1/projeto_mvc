using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeto_mvc2023
{
    class LoginBLL
    {
        // Método que realiza a chamada do método de pesquisa na camada DAL.
        public bool GetLoginBll(LoginDTO loginDTO)
        {
            // validação do usuario
            // chamada do método de pesquisa de login na camda DAL.
            LoginDAL login = new LoginDAL();
            bool retorno = login.GetLoginDAL(loginDTO);
            // se o retorno do método de pesquisa da camada DAL for verdadeiro retorna treu
            if (retorno)
            {
                return true;
            }

            return false;
        }
    }
}
