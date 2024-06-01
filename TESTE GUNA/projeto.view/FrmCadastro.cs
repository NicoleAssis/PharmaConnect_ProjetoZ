using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TESTE_GUNA.projeto.view
{
    public partial class FrmCadastro : Form
    {
        public FrmCadastro()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            //abrir a tela de login
            FrmLogin telaLogin = new FrmLogin();
            //esconde a tela anterior

            telaLogin.Show();
            this.Hide();
        }

        private void btnX_Click(object sender, EventArgs e)
        {
            //button fechar o programa (X)
            Environment.Exit(0);
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            FrmMenu telaMenu = new FrmMenu();
            telaMenu.Show();
            this.Hide();
        }

        private void guna2TextBox2_Click(object sender, EventArgs e)
        {
            //aparece o masked box em cima desse text box p coletar os dados do CPF corretamente
            txtCPF.Visible= true;
            txtBase.Enabled= false;
        }

        private void txtNome_Click(object sender, EventArgs e)
        {
            txtNome.Text = " ";
        }

        private void txtCPF_Click(object sender, EventArgs e)
        {
            txtCPF.Text = " ";
        }

        private void txtEmail_Click(object sender, EventArgs e)
        {
            txtEmail.Text = " ";
        }

        private void txtSenha_Click(object sender, EventArgs e)
        {
            txtSenha.Text = "";
            txtSenha.PasswordChar = '*';
        }

        private void checkBoxMostrarSenha_CheckedChanged(object sender, EventArgs e)
        {
            if(txtSenha.PasswordChar == '*')
            {
                //remove o passwordChar
                txtSenha.PasswordChar = '\0';
            }
            else
            {
                //caso deseja colocar o passwordChar novamente
                txtSenha.PasswordChar = '*';
            }

        }
    }
}
