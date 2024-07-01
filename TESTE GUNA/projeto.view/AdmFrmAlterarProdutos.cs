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
    public partial class AdmFrmAlterarProdutos : Form
    {
        public AdmFrmAlterarProdutos()
        {
            InitializeComponent();
        }

        private void txtPesquisa_Click(object sender, EventArgs e)
        {
            txtPesquisa.Text = "";
        }

        private void btnX_Click(object sender, EventArgs e)
        {
            //button fechar o programa (X)
            this.Close();
        }

        private void AdmFrmAlterarProdutos_Load(object sender, EventArgs e)
        {

        }

        private void btnSalvarAlteracoes_Click(object sender, EventArgs e)
        {
            FrmMessageBox mensagem = new FrmMessageBox();
            mensagem.Mensagem("ALTERAÇÕES SALVAS COM SUCESSO!");
            mensagem.ShowDialog();
            this.Close();
        }

        private void txtNomeCartao_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPreco_TextChanged(object sender, EventArgs e)
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
    }
}
