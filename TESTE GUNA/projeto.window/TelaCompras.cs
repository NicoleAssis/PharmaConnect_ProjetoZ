using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Globalization;
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
    public partial class TelaCompras : Form
    {
       
        public static List<Produto> listaProdutosEnter = new List<Produto>();
        private TelaHome telaHome;

        public TelaCompras(TelaHome home)
        {
            InitializeComponent();
            this.telaHome = home;
            this.DoubleBuffered = true;//parar de travar a tela
           
        }

        #region PrintarTela

        public void PrintarTela(Form form)
        {
            if (this.panelAbrirTela.Controls.Count > 0)
                this.panelAbrirTela.Controls.RemoveAt(0);

            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            this.panelAbrirTela.Controls.Add(form);
            this.panelAbrirTela.Tag = form;
            form.Show();
        }

        public void PrintarTelaPagamento()
        {
            TelaPagamento telaPagamento = new TelaPagamento(this);
            PrintarTela(telaPagamento);
            telaPagamento.BringToFront();
        }
        public void PrintarTelaFinalizarPagamento()
        {
            TelaFinalizarPagamento tela = new TelaFinalizarPagamento(this, this.telaHome);
            PrintarTela(tela);
            tela.BringToFront();
        }

        #endregion

        public static string totalCarrinho;

        private void TelaCompras_Load(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();

            UserControlCarrinho res = new UserControlCarrinho();
            int key = ClienteDAO.id_conectado;
            res.searchResult(key);

            loadDetails();
            CarrinhoDAO dao = new CarrinhoDAO();
            totalCarrinho = (dao.TotalCarrinho()).ToString("F2", CultureInfo.InvariantCulture);
            lbltotalCarrinho.Text = totalCarrinho;
            
        }
        private void loadDetails()
        {

            foreach (CarrinhoDAO p in CarrinhoDAO.list)
            {
                UserControlCarrinho res = new UserControlCarrinho();
                res.DetailsC(p);
                flowLayoutPanel1.Controls.Add(res);
            }
           //CarrinhoDAO dao = new CarrinhoDAO();
           //TotalCarrinho = dao.totalCarrinho.ToString();
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnEfetuarCompra_Click(object sender, EventArgs e)
        {
            //criar uma tela antes do frete
            // TelaFrete tela = new TelaFrete(this);
            //  PrintarTela(tela);
            //tela.BringToFront();

            TelaPagamento tela = new TelaPagamento(this);
            PrintarTela(tela);
            tela.BringToFront();
        }

        //continuar comprando
        private void btnIrParaCarrinho_Click(object sender, EventArgs e)
        {
            //TelaProdutos telaProdutos = new TelaProdutos(this.telaHome);
            //this.telaHome.PrintarTelaForaDaHome(telaProdutos);
        }
    }
}
