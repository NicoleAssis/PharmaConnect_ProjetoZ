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
            //pergunta se deseja efetuar o pagamento ou nao
            FrmMessageBox frmMessageBox = new FrmMessageBox();
            frmMessageBox.RetornaSimNao("DESEJA ALTERAR A SENHA?");
            frmMessageBox.ShowDialog();

            if (frmMessageBox.btnSimClick == true)
            {
                
                //se confirmou que deseja efetuar o pagamento
                frmMessageBox.Mensagem("SENHA ALTERADA COM SUCESSO!");
                frmMessageBox.ShowDialog();
                this.Close();
            }
            else if (frmMessageBox.btnNaoClick == true)
            {
                //se nao quer efetuar o pagamento
                this.Close();
                FrmPerfil telaPerfil = new FrmPerfil();
                telaPerfil.ShowDialog();
            }
            else
            {
                frmMessageBox.Mensagem("Selecione SIM ou NAO");
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
