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
    public partial class AdmTelaCategoria : Form
    {
        private AdmTelaHome admHome;

        public AdmTelaCategoria(AdmTelaHome home)
        {
            InitializeComponent();
            this.admHome = home;
            this.DoubleBuffered = true;//parar de travar a tela
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
           
        }
        private void AdmTelaCategoria_Load(object sender, EventArgs e)
        {

            ProdutoDAO dao = new ProdutoDAO();

            DataGridViewProdutos.DataSource = dao.ListarProdutos();

        }


        private void DataGridViewVendas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
                
          
        }

        private void DataGridViewProdutos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void AdmTelaCategoria_Load_1(object sender, EventArgs e)
        {


            ProdutoDAO dao = new ProdutoDAO();

            DataGridViewProdutos.DataSource = dao.ListarVendas();

        }

        private void boxCategoria_SelectedValueChanged(object sender, EventArgs e)
        {
            if (boxCategoria.SelectedItem != null)
            {
                // Obtém o item selecionado
                string selectedCategory = boxCategoria.SelectedItem.ToString();

                ProdutoDAO dao = new ProdutoDAO();

                DataGridViewProdutos.DataSource = dao.ListarVendasCategoria(selectedCategory);
            }
            else
            {
                ProdutoDAO dao = new ProdutoDAO();

                DataGridViewProdutos.DataSource = dao.ListarProdutos();
            }
        }

        private void txtPesquisa_KeyPress(object sender, KeyPressEventArgs e)
        {
            string nome = txtPesquisa.Text;

            ProdutoDAO dao = new ProdutoDAO();
            DataGridViewProdutos.DataSource = dao.BuscarProdutoPorNome(nome);

          
        }
    }
}
