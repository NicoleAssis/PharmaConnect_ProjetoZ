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
    public partial class AdmFrmProdutos : Form
    {
        public AdmFrmProdutos()
        {
            InitializeComponent();
        }

        private void txtPesquisa_Click(object sender, EventArgs e)
        {
            txtPesquisa.Text = "";
        }

        private void guna2GradientButton2_Click(object sender, EventArgs e)
        {
            AdmFrmAlterarProdutos telaAlterarProdutos = new AdmFrmAlterarProdutos();
            telaAlterarProdutos.ShowDialog();
        }

        private void btnVendas_Click(object sender, EventArgs e)
        {
            AdmFrmMenu telaMenu = new AdmFrmMenu();
            this.Close();
            telaMenu.ShowDialog();
        }

        private void btnX_Click(object sender, EventArgs e)
        {
            //button fechar o programa (X)
            Environment.Exit(0);
        }

        private void btnAdicionarProdutos_Click(object sender, EventArgs e)
        {
            AdmFrmAdicionarProduto telaAdicionarProdutos = new AdmFrmAdicionarProduto();
            telaAdicionarProdutos.ShowDialog();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            //volta para a tela e login
            FrmLogin telaLogin = new FrmLogin();
            this.Close();
            telaLogin.Show();
        }
    }
}
