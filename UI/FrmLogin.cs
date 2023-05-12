using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projeto_mvc2023.UI
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            LoginDTO loginDTO = new LoginDTO
            {
                Email = txtbEmail.Text,
                Senha = txtBSenha.Text
            };

            LoginBLL login = new LoginBLL();
            bool retorno = login.GetLoginBll(loginDTO);

            if (retorno)
            {
                // MessageBox.Show("LOGIN OK");

                // carregar o formMenu criando um obl
                FrmMenu frmMenu = new FrmMenu();

                //carregar o menu na tela
                frmMenu.Show();

                // ocultar o FrmLogin
                this.Hide();
            }
            else
            {
                MessageBox.Show("Não foi possível realizar o login, tente novamente.");
            }
        }
    }
}
