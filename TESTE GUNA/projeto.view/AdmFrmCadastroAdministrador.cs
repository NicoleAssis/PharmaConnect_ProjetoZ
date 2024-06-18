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
            //Instancei Cliente Dao para executar 
            AdministradorDAO dao = new AdministradorDAO();

            //recebo dados txt
            string cnpj_string = txtCNPJ.Text;
            string email = txtEmail.Text;

            // 1° Validação: CPF
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
                FrmMessageBox mensagem = new FrmMessageBox();
                mensagem.Mensagem("Cadastro Efetuado");


                //abrir a tela de login
                AdmFrmCadastroAdministradorC2 telaLogin = new AdmFrmCadastroAdministradorC2();
                ////esconde a tela anterior

                new Helpers().LimparTela(this);
                telaLogin.Show();
                this.Hide();
            }
            else if (validacaoCNPJ == true && validacaoCNPJ == false || validacaoEmail == false && validacaoCNPJ == true)
            {
                MessageBox.Show("CNPJ Inválido, Por Favor digitar novamente");
            }
            else
            {
                MessageBox.Show("CNPJ Inválido, Por Favor digitar novamente");
            }


            #endregion
        }
    }
}
