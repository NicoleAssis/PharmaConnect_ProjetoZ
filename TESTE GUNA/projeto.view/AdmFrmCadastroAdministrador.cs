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

namespace TESTE_GUNA.projeto.view
{
    public partial class AdmFrmCadastroAdministrador : Form
    {
        public AdmFrmCadastroAdministrador()
        {
            InitializeComponent();
        }

        private void txtBase_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtBase2_TextChanged(object sender, EventArgs e)
        {

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

        private void btnX_Click(object sender, EventArgs e)
        {
            //button fechar o programa (X)
            this.Close();
        }

        private void txtBase3_TextChanged(object sender, EventArgs e)
        {

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

            // Se todos os campos estiverem preenchidos corretamente, cria o objeto Administrador
            Administrador admin = new Administrador
            {
                cnpj = txtCNPJ.Text,
                nome = txtNome.Text,
                email = txtEmail.Text,
                celular = txtCelular.Text,
                senha = txtSenha.Text,
            };

            // Passa o objeto admin para a próxima tela (Form2)
            AdmFrmCadastroAdministradorC2 form2 = new AdmFrmCadastroAdministradorC2(admin);
            form2.Show(); // Certifique-se de estar chamando o método Show() na instância do formulário
            this.Hide();
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




        /*//Instancei Cliente Dao para executar 
        AdministradorDAO dao = new AdministradorDAO();

        //recebo dados txt
        string cnpj_string = txtCNPJ.Text;
        string email = txtEmail.Text;

        // 1° Validação: Cnpj
        bool validacaoCNPJ = AdministradorDAO.ValidarCNPJ((cnpj_string));

        //2° Validação: Email
        bool validacaoEmail = Validador.ValidarEmail(email);


        #region Validando Email e CPnjp
        if (validacaoEmail && validacaoCNPJ)
        {
            long cnpj_inteiro = long.Parse((txtCNPJ.Text));
            Administrador obj = new Administrador
            {
                nome = txtNome.Text,
                email = txtEmail.Text,
                nivel = 1,
                senha = txtSenha.Text,
                cnpj = cnpj_inteiro.ToString()
            };

            dao.CadastrarAdministador1(obj);
            TelaMessageBox mensagem = new TelaMessageBox();
            mensagem.Mensagem("Cadastro Efetuado");
            txtNome.Clear();
            txtEmail.Clear();
            txtSenha.Clear();
            txtCNPJ.Clear();
            txtBase.Clear();


            //abrir a tela de login
            AdmFrmCadastroAdministradorC2 telaLogin2 = new AdmFrmCadastroAdministradorC2();
            ////esconde a tela anterior

            new Helpers().LimparTela(this);
            telaLogin2.Show();
            this.Hide();
        }
        else if (validacaoCNPJ == true && validacaoCNPJ == false)
        {
            MessageBox.Show("CNPJ Inválido, Por Favor digitar novamente");
            txtNome.Clear();
            txtEmail.Clear();
            txtSenha.Clear();
            txtCNPJ.Clear();
            txtBase.Clear();


        }
        else
        {
            MessageBox.Show("CNPJ Inválido, Por Favor digitar novamente");
            txtNome.Clear();
            txtEmail.Clear();
            txtSenha.Clear();

        }


        #endregion*/
    }
}

