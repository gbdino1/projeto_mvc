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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            LoginDTO loginDTO = new LoginDTO
            {
                lblEmail = txtbEmail.Text,
                lblSenha = txtBSenha.Text
            };

            LoginBLL login = new LoginBLL();
            bool retorno = login.GetLoginBLL(loginDTO);

            if (retorno)
            {
                MessageBox.Show("lOGIN OK");
            }
            else
            {
                MessageBox.Show("Não foi possível realizar o login, tente novamente.");
            }
        }
    }
}
