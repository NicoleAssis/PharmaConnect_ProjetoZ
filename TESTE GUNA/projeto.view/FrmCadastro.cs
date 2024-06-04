using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TESTE_GUNA.projeto.dao;
using TESTE_GUNA.projeto.model;

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

        private void txtNome_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCPF_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void txtSenha_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCadastrar_Click_1(object sender, EventArgs e)
        {
            Cliente obj = new Cliente
            {
                nome_cliente = txtNome.Text,
                email_cliente = txtEmail.Text,
                nivel_acesso = 2,
                senha_cliente = txtSenha.Text,
                cpf_cnpj_cliente = txtCPF.Text.Replace(",", ".")
            };

            ClienteDAO dao = new ClienteDAO();
            dao.CadastrarClienteC1(obj);
            FrmMessageBox mensagem = new FrmMessageBox();
            mensagem.Mensagem("Cadastro Efetuado");


            //abrir a tela de login
            FrmLogin telaLogin = new FrmLogin();
            ////esconde a tela anterior

            telaLogin.Show();
            this.Hide();
        }


    }
}
