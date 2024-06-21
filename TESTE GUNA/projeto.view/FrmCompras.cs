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
    public partial class FrmCompras : Form
    {
        public FrmCompras()
        {
            InitializeComponent();
        }

        private void btnX_Click(object sender, EventArgs e)
        {
            //fechar o programa
            Environment.Exit(0);
        }

        #region buttonsDoMenu

        private void btnHome_Click(object sender, EventArgs e)
        {
            FrmMenu telaMenu = new FrmMenu();
            this.Close();
            telaMenu.Show();
        }

        private void btnDepartamentos_Click(object sender, EventArgs e)
        {
            FrmDepartamentos telaDepartamentos = new FrmDepartamentos();
            this.Close();
            telaDepartamentos.Show();
        }

        private void btnPerfil_Click(object sender, EventArgs e)
        {
            FrmPerfil telaPerfil = new FrmPerfil();
            this.Close();
            telaPerfil.Show();
        }

        #endregion


        public void DeletarProduto(UserControlComprasProdutos produto)
        {
            scrollCompras.Controls.Remove(produto);
            scrollCompras.Refresh();
        }


        private void lblCalcularFrete_Click(object sender, EventArgs e)
        {
            FrmFrete telaFrete = new FrmFrete();
            telaFrete.ShowDialog();
        }

        private void btnPagamento_Click(object sender, EventArgs e)
        {
            FrmPagamento telaPag = new FrmPagamento();
            telaPag.ShowDialog();
        }

        private void btnComprasFinalizadas_Click(object sender, EventArgs e)
        {
            FrmComprasConcluidas telaComprasConcluidas = new FrmComprasConcluidas();
            telaComprasConcluidas.ShowDialog();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void FrmCompras_Load(object sender, EventArgs e)
        {
            //printa os produtos na tela de scroll
            for (int i = 0; i <= 4; i++)
            {
                UserControlComprasProdutos userControlProdutos = new UserControlComprasProdutos();
                userControlProdutos.printarProduto(1);
                scrollCompras.Controls.Add(userControlProdutos);
            }

            
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            //volta para a tela e login
            FrmLogin telaLogin = new FrmLogin();
            this.Close();
            telaLogin.Show();
        }

        private void scrollCompras_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel18_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnCompras_Click(object sender, EventArgs e)
        {

        }
    }
}
