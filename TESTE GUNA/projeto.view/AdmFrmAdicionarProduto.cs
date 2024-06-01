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
    public partial class AdmFrmAdicionarProduto : Form
    {
        public AdmFrmAdicionarProduto()
        {
            InitializeComponent();
        }

        private void btnX_Click(object sender, EventArgs e)
        {
            //button fechar o programa (X)
            this.Close();
        }

        private void txtNomeCartao_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNomeCartao_Click(object sender, EventArgs e)
        {
            txtNomeCartao.Text = "";
        }

        private void txtPreco_Click(object sender, EventArgs e)
        {
            txtPreco.Text = "";
        }

        private void txtQuantidade_Click(object sender, EventArgs e)
        {
            txtQuantidade.Text = "";
        }

        private void btnCriarProduto_Click(object sender, EventArgs e)
        {
            FrmMessageBox mensagem = new FrmMessageBox();
            mensagem.Mensagem("PRODUTO CRIADO COM SUCESSO!");
            mensagem.ShowDialog();
        }
    }
}
