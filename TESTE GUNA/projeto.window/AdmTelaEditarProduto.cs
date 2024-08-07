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
    public partial class AdmTelaEditarProduto : Form
    {
        public AdmTelaEditarProduto()
        {
            InitializeComponent();
        }

        private void btnX_Click(object sender, EventArgs e)
        {
            //button fechar a tela de pagamento
            this.Close();
        }

        private void txtMensagem_Click(object sender, EventArgs e)
        {

        }

        private void btnAlterarSenha_Click(object sender, EventArgs e)
        {
            TelaMessageBoxSucess mensagem = new TelaMessageBoxSucess();
            mensagem.Mensagem("PRODUTO EDITADO COM SUCESSO!");
            mensagem.ShowDialog();
            this.Close();
        }
    }
}
