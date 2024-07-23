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

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            TelaMessageBoxSucess messageBox = new TelaMessageBoxSucess();
            messageBox.Mensagem("ADMINISTRADOR CADASTRADO COM SUCESSO!");
            messageBox.ShowDialog();
            this.Close();
            this.admHome.ReiniciarHome();
        }
    }
}
