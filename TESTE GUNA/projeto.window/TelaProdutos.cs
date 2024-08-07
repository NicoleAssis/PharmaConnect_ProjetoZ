using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;
using TESTE_GUNA.projeto.dao;
using TESTE_GUNA.projeto.model;
using static System.Net.Mime.MediaTypeNames;

namespace TESTE_GUNA.projeto.window
{
    public partial class TelaProdutos : Form
    {

        public static List<Produto> listaProdutosEnter = new List<Produto>();
        private TelaHome telaHome;

        public TelaProdutos(TelaHome home)
        {
            InitializeComponent();
            this.telaHome = home;
            this.DoubleBuffered = true;//parar de travar a tela
        }


        //public TelaProdutos()
        //{
        //    InitializeComponent();
            
        //    this.DoubleBuffered = true;//parar de travar a tela
        //}






        private void TelaProdutos_Load(object sender, EventArgs e)
        {
            

            populateItems();






        }
        public int vt;

        public object Application { get; private set; }
        public void populateItems()
        {
            ProdutoDAO dao = new ProdutoDAO();
            vt = dao.contValores();
            List<UserControlProduto> listProdutos = new List<UserControlProduto>();

            for (int i = 0; i < 50; i++)
            {
                dao.GetDetails(i + 1);

                // Verifica se o nome do produto é nulo, vazio ou contém apenas espaços em branco
                if (string.IsNullOrWhiteSpace(dao.nomeProduto))
                {
                    continue;
                }

                UserControlProduto userControlProduto = new UserControlProduto
                {
                    Produto = dao.nomeProduto,
                    Descricao = dao.descProduto,
                    PrecoProduto = dao.precoProduto.ToString(),
                    Codigo = dao.Id_Produto.ToString(),
                };

                listProdutos.Add(userControlProduto);
            }

            flowLayoutPanel1.Controls.Clear(); // Limpar controles antigos antes de adicionar novos
            foreach (var produtoControl in listProdutos)
            {
                flowLayoutPanel1.Controls.Add(produtoControl);
            }
        }


        private void btnPesquisar_Click(object sender, EventArgs e)
        {
        }

        private void loadDetails()
        {
            foreach (ProdutoDAO p in ProdutoDAO.list)
            {
                UserControlProduto res = new UserControlProduto();
                res.DetailsB(p);
                flowLayoutPanel1.Controls.Add(res);
            }
        }




        private void txtPesquisa_KeyPress(object sender, KeyPressEventArgs e)
        {


        }

        private void txtPesquisa_TextChanged(object sender, EventArgs e)
        {
            if (txtPesquisa.TextLength >= 1)
            {
                flowLayoutPanel1.Controls.Clear();

                UserControlProduto res = new UserControlProduto();
                res.searchResult(txtPesquisa.Text);

                loadDetails();
            }

            if (String.IsNullOrWhiteSpace(txtPesquisa.Text))
            {
                populateItems();
                return;  // isso faz com que você saia do método e não execute os próximos processamentos
            }



        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnIrParaCarrinho_Click(object sender, EventArgs e)
        {

            TelaCompras tela = new TelaCompras(this.telaHome);
            this.telaHome.PrintarTela(tela);
            tela.BringToFront();
        }
    }
}