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
using TESTE_GUNA.projeto.view;

namespace TESTE_GUNA.projeto.window
{
    public partial class TelaAlterarSenha : Form
    {
        public TelaAlterarSenha()
        {
            InitializeComponent();
        }

        private void txtMensagem_Click(object sender, EventArgs e)
        {

        }

        private void btnX_Click(object sender, EventArgs e)
        {
            //button fechar a tela de pagamento
            this.Close();
        }

        private void checkBoxMostrarSenha_CheckedChanged(object sender, EventArgs e)
        {
            if (txtSenhaAtual.PasswordChar == '*')
            {
                //remove o passwordChar
                txtSenhaAtual.PasswordChar = '\0';
                txtNovaSenha.PasswordChar = '\0';
                txtConfirmeSenha.PasswordChar = '\0';
            }
            else
            {
                //caso deseja colocar o passwordChar novamente
                txtSenhaAtual.PasswordChar = '*';
                txtNovaSenha.PasswordChar = '*';
                txtConfirmeSenha.PasswordChar = '*';
            }
        }

        private void btnAlterarSenha_Click(object sender, EventArgs e)
        {
            if (txtSenhaAtual.Text == "" || txtConfirmeSenha.Text == "" || txtNovaSenha.Text == "")
            {
                TelaMessageBox mensagem = new TelaMessageBox();
                mensagem.Mensagem("Preencha todos os campos!");
                mensagem.ShowDialog();
            }
            else if (txtNovaSenha.Text != txtConfirmeSenha.Text)
            {
                TelaMessageBox mensagem = new TelaMessageBox();
                mensagem.Mensagem("Senhas diferentes!");
                mensagem.ShowDialog();
            }
            else
            {
                SenhaDAO senhaDAO = new SenhaDAO();

                if ((senhaDAO.ConfirmarSenha(txtSenhaAtual.Text)) == true)
                {
                    //pergunta se deseja efetuar o pagamento ou nao
                    TelaMessageBox TelaMessageBox = new TelaMessageBox();
                    TelaMessageBox.RetornaSimNao("DESEJA ALTERAR A SENHA?");
                    TelaMessageBox.ShowDialog();

                    if (TelaMessageBox.btnSimClick == true)
                    {

                        senhaDAO.AlterarSenha(txtNovaSenha.Text);


                        //se confirmou que deseja efetuar o pagamento
                        TelaMessageBoxSucess messageBoxSucess = new TelaMessageBoxSucess();
                        messageBoxSucess.Mensagem("SENHA ALTERADA COM SUCESSO!");
                        messageBoxSucess.ShowDialog();
                        this.Close();
                    }
                    else if (TelaMessageBox.btnNaoClick == true)
                    {
                        this.Close();
                    }
                    else
                    {
                        TelaMessageBox.Mensagem("Selecione SIM ou NAO");
                    }
                }
                else
                {
                    TelaMessageBox mensagem = new TelaMessageBox();
                    mensagem.Mensagem("Senha atual incorreta!");
                    mensagem.ShowDialog();
                }


            }

        }
    }
}
