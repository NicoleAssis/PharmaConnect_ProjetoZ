using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TESTE_GUNA.projeto.dao;
using TESTE_GUNA.projeto.model;
using TESTE_GUNA.projeto.view;

namespace TESTE_GUNA.projeto.window
{
    public partial class AdmTelaCadastrar : Form
    {
        private AdmTelaHome admHome;

        public AdmTelaCadastrar(AdmTelaHome home)
        {
            InitializeComponent();
            this.admHome = home;
            this.DoubleBuffered = true;//parar de travar a tela
        }

        private void btnX_Click(object sender, EventArgs e)
        {
            //button fechar o programa (X)
            this.Close();
        }

        private void checkBoxMostrarSenha_CheckedChanged(object sender, EventArgs e)
        {
            if (txtSenha.PasswordChar == '*')
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

        private void txtBase_Click(object sender, EventArgs e)
        {
            //aparece o masked box em cima desse text box p coletar os dados do CPF corretamente
            txtCNPJ.Visible = true;
            txtBase.Enabled = false;
        }

        private void txtBase2_Click(object sender, EventArgs e)
        {
            //aparece o masked box em cima desse text box p coletar os dados do CPF corretamente
            txtTelefone.Visible = true;
            txtBase2.Enabled = false;
        }

        private void txtBase3_Click(object sender, EventArgs e)
        {
            //aparece o masked box em cima desse text box p coletar os dados do CPF corretamente
            txtCelular.Visible = true;
            txtBase3.Enabled = false;
        }

        // Função para validar o formato do email
        private bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            // Validação dos campos
            if (string.IsNullOrWhiteSpace(txtCNPJ.Text))
            {
                TelaMessageBox message = new TelaMessageBox();
                message.Mensagem("Por favor, preencha o campo CNPJ.");
                message.ShowDialog();
                return;
            }
            if (string.IsNullOrWhiteSpace(txtNome.Text))
            {
                TelaMessageBox message = new TelaMessageBox();
                message.Mensagem("Por favor, preencha o campo Nome.");
                message.ShowDialog();
                return;
            }
            if (string.IsNullOrWhiteSpace(txtEmail.Text) || !IsValidEmail(txtEmail.Text))
            {
                TelaMessageBox message = new TelaMessageBox();
                message.Mensagem("Por favor, preencha um email válido.");
                message.ShowDialog();
                return;
            }
            if (string.IsNullOrWhiteSpace(txtCelular.Text))
            {
                TelaMessageBox message = new TelaMessageBox();
                message.Mensagem("Por favor, preencha o campo Celular.");
                message.ShowDialog();
                return;
            }
            if (string.IsNullOrWhiteSpace(txtSenha.Text))
            {
                TelaMessageBox message = new TelaMessageBox();
                message.Mensagem("Por favor, preencha o campo Senha.");
                message.ShowDialog();
                return;
            }

            if(txtCelular.Text != "" && txtCNPJ.Text != "" && txtEmail.Text != "" && txtNome.Text != "" && txtSenha.Text != "" && txtTelefone.Text != "")
            {
                // Se todos os campos estiverem preenchidos corretamente, cria o objeto Administrador
                Administrador admin = new Administrador
                {
                    cnpj = txtCNPJ.Text,
                    nome = txtNome.Text,
                    email = txtEmail.Text,
                    celular = txtCelular.Text,
                    senha = txtSenha.Text,
                };


                // Chama o método de cadastro com o objeto completo
                AdministradorDAO dao = new AdministradorDAO();
                dao.CadastrarAdministador(admin);

                TelaMessageBoxSucess messageBox = new TelaMessageBoxSucess();
                messageBox.Mensagem("ADMINISTRADOR CADASTRADO COM SUCESSO!");
                messageBox.ShowDialog();
                this.Close();
                this.admHome.ReiniciarHome();
            }

           

        }
    }
}
