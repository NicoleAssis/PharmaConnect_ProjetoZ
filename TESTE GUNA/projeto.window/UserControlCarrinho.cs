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
using TESTE_GUNA.projeto.model;

namespace TESTE_GUNA.projeto.window
{
    public partial class UserControlCarrinho : UserControl
    {

        static int addDiminuitMaleavel;


        private TelaHome telaHome;


        public UserControlCarrinho(TelaHome home)
        {
            InitializeComponent();
            this.telaHome = home;
            this.DoubleBuffered = true;//parar de travar a tela
        }


        #region Propriedades

        private string _nomeProduto;
        private string _precoUnit;
        private string _precoTotal;
        private string _idcodigo;
        private string _quantidade;
        

        [Category("Custom Pro")]
        public string Produto
        {
            get { return _nomeProduto; }
            set { _nomeProduto = value; label3.Text = value; }
        }

        [Category("Custom Pro")]
        public string Codigo
        {
            get { return _idcodigo; }
            set { _idcodigo = value; txtCodigo.Text = value; }
        }


        [Category("Custom Pro")]
        public string PrecoUnitario
        {
            get { return _precoUnit; }
            set { _precoUnit = value; txtPreco.Text = value; }
        }



        [Category("Custom Pro")]
        public string PrecoTotal
        {
            get { return _precoTotal; }
            set { _precoTotal = value; lblvalortotal.Text = value; }
        }

        #endregion


       [Category("Custom Pro")]
        public string Quantidade
        {
            get { return _quantidade; }
            set { _quantidade = value; txtQtd.Text = value; }
        }

        




        public void DetailsC(CarrinhoDAO d)
        {
            Codigo = d.id_produtoCarrinho.ToString();
            PrecoUnitario = d.subtotalCarrinho.ToString();
            Quantidade = d.qtd_Carrinho.ToString() ;
            PrecoTotal = d.totalCarrinho.ToString();
            Produto = d.NomeProduto;
            

        }

        public void searchResult(int key)
        {
            CarrinhoDAO get = new CarrinhoDAO();
            get.Search(key);

            Codigo = get.id_produtoCarrinho.ToString();
            PrecoUnitario = get.subtotalCarrinho.ToString();
            Quantidade = get.qtd_Carrinho.ToString();
            PrecoTotal = get.totalCarrinho.ToString();
            Produto = get.NomeProduto;
        }

        private void RSMoeda_Click(object sender, EventArgs e)
        {

        }

        private void txtPreco_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void guna2Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnMenos_Click(object sender, EventArgs e)
        {
            int con = Convert.ToInt32(Quantidade);
            if (con > 0)
            {

                CarrinhoDAO dao = new CarrinhoDAO();

                CarrinhoDAO obj = new CarrinhoDAO
                {
                    id_produtoCarrinho = Convert.ToInt32(Codigo),
                    qtd_Carrinho = Convert.ToInt32(Quantidade) - 1,
                    totalCarrinho = Convert.ToInt32(Quantidade) * Convert.ToDecimal(PrecoUnitario),


                };
                Quantidade = (Convert.ToInt32(Quantidade) - 1).ToString();
                PrecoTotal = (Convert.ToInt32(Quantidade) * Convert.ToDecimal(PrecoUnitario)).ToString() ;
                dao.AlterarProdutoCarrinho(obj);
            }


        }

        private void btnaddcarrinho_Click(object sender, EventArgs e)
        {
            

                CarrinhoDAO dao = new CarrinhoDAO();

                CarrinhoDAO obj = new CarrinhoDAO
                {
                    id_produtoCarrinho = Convert.ToInt32(Codigo),
                    qtd_Carrinho = Convert.ToInt32(Quantidade) + 1,
                    totalCarrinho = Convert.ToInt32(Quantidade) * Convert.ToDecimal(PrecoUnitario),


                };
                Quantidade = (Convert.ToInt32(Quantidade) + 1).ToString();
                PrecoTotal = (Convert.ToInt32(Quantidade) * Convert.ToDecimal(PrecoUnitario)).ToString();
                dao.AlterarProdutoCarrinho(obj);
            
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            CarrinhoDAO dao = new CarrinhoDAO();

            CarrinhoDAO obj = new CarrinhoDAO
            {
                id_produtoCarrinho = Convert.ToInt32(Codigo),
                
            };
            
            dao.Delete(obj);


            TelaCompras tela = new TelaCompras(this.telaHome);
            this.telaHome.PrintarTela(tela);
            tela.BringToFront();
        }
    }
}
