using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            TelaMessageBoxSucess messageBoxSucess = new TelaMessageBoxSucess();
            messageBoxSucess.Mensagem("SENHA ALTERADA COM SUCESSO!");
            messageBoxSucess.ShowDialog();
            this.Close();
        }
    }
}
