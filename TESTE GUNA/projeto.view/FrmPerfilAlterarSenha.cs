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

namespace TESTE_GUNA.projeto.view
{
    public partial class FrmPerfilAlterarSenha : Form
    {
        public FrmPerfilAlterarSenha()
        {
            InitializeComponent();
        }

        private void btnX_Click(object sender, EventArgs e)
        {
            //button fechar a tela
            this.Close();
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

                if((senhaDAO.ConfirmarSenha(txtSenhaAtual.Text)) == true)
                { 
                    //pergunta se deseja efetuar o pagamento ou nao
                    TelaMessageBox TelaMessageBox = new TelaMessageBox();
                    TelaMessageBox.RetornaSimNao("DESEJA ALTERAR A SENHA?");
                    TelaMessageBox.ShowDialog();

                    if (TelaMessageBox.btnSimClick == true)
                    {

                        senhaDAO.AlterarSenha(txtNovaSenha.Text);


                        //se confirmou que deseja efetuar o pagamento
                        FrmMessageSucess frmMessageSucess = new FrmMessageSucess();
                        frmMessageSucess.MensagemDeSucesso("SENHA ALTERADA COM SUCESSO!");
                        frmMessageSucess.ShowDialog();
                        this.Close();
                    }
                    else if (TelaMessageBox.btnNaoClick == true)
                    {
                        //se nao quer efetuar o pagamento
                        this.Close();
                        FrmPerfil telaPerfil = new FrmPerfil();
                        telaPerfil.ShowDialog();
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
    }
}
