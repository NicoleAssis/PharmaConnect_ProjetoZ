using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Guna.UI2.WinForms;
using TESTE_GUNA.projeto.dao;
using TESTE_GUNA.projeto.model;
using TESTE_GUNA.projeto.window;

namespace TESTE_GUNA.projeto.view
{
    public partial class FrmMenu : Form
    {
        public FrmMenu()
        {
            InitializeComponent();
        }

        private TelaLogin TelaLogin;

        public FrmMenu(TelaLogin telaLogin)
        {
            InitializeComponent();
            TelaLogin = telaLogin;
        }


        private void guna2HtmlLabel1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
             
        }


        #region Buttons
        private void btnX_Click(object sender, EventArgs e)
        {
            //button fechar o programa (X)
            Environment.Exit(0);
        }


        private void btnDepartamentos_Click_1(object sender, EventArgs e)
        {
            //abrir a tela de cadastro
            FrmDepartamentos telaDepartamentos = new FrmDepartamentos();
            //esconde a tela anterior
            this.Close();
            //tela abre no centro
            //telaDepartamentos.StartPosition = FormStartPosition.CenterScreen;
            telaDepartamentos.Show();
        }

        private void btnCompras_Click(object sender, EventArgs e)
        {
            FrmCompras telaCompras = new FrmCompras();
            //esconde a tela anterior
            this.Close();
            telaCompras.Show();
        }

        private void btnPerfil_Click(object sender, EventArgs e)
        {
            FrmPerfil telaPerfil = new FrmPerfil();
            //esconde tela anterior
            this.Close();
            telaPerfil.Show();
        }
        private void btnComprasBarraPesquisa_Click(object sender, EventArgs e)
        {
            FrmCompras telaCompras = new FrmCompras();
            //esconde a tela anterior
            this.Close();
            telaCompras.Show();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            //mesma tela
        }
        private void btnPerfilBarraPerquisa_Click(object sender, EventArgs e)
        {
            FrmPerfil telaPerfil = new FrmPerfil();
            //esconde tela anterior
            this.Close();
            telaPerfil.Show();
        }

        #endregion

        private void FrmMenu_Load(object sender, EventArgs e)
        {

            //populateItems();

           // printa os produtos na tela de scroll
            //for (int i = 0; i <= 40; i++)
            //{
            //    UserControlProduto userControlProdutos = new UserControlProduto();
            //    userControlProdutos.PrintarProduto(1);
            //    scrollProdutos.Controls.Add(userControlProdutos);
            //}
        }

        //private void scrollBar_Scroll(object sender, ScrollEventArgs e)
        //{
        //    scrollProdutos.AutoScrollPosition = new System.Drawing.Point(0, e.NewValue);
        //}

        private void txtPesquisa_Click(object sender, EventArgs e)
        {
            txtPesquisa.Text = " ";
        }

        private void scrollProdutos_Paint(object sender, PaintEventArgs e)
        {


        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            //volta para a tela e login
            TelaLogin telaLogin = new TelaLogin();
            this.Close();
            telaLogin.Show();
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
        public int j = 1;
        //private void populateItems()
        //{
        //    //populate it here

        //    UserControlProduto[] usercontrolproduto = new UserControlProduto[20];


        //    for (int i = 0; i < usercontrolproduto.Length; i++)
        //    {

        //        usercontrolproduto[i] = new UserControlProduto();
        //        FrmDepartamentoEscolhido tela = new FrmDepartamentoEscolhido();
        //        ProdutoDAO dao = new ProdutoDAO();
                


        //        dao.GetDetails(j);
        //        usercontrolproduto[i].NomeProduto = dao.nome_reader;
        //        usercontrolproduto[i].Dep = dao.dep_reader;
        //        usercontrolproduto[i].Preco = dao.preco_reader;
        //        usercontrolproduto[i].Desc = dao.desc_reader;






        //        if (flowLayoutPanel1.Controls.Count < 0)
        //        {

        //            flowLayoutPanel1.Controls.Clear();
        //        }
        //        else
        //        {
        //            flowLayoutPanel1.Controls.Add(usercontrolproduto[i]);
        //            j++;
        //        }



        //    }

        //}
    }
}
