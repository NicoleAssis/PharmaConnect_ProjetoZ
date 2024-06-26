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

namespace TESTE_GUNA.projeto.view
{
    public partial class FrmADMExcluirProduto : Form
    {
        public FrmADMExcluirProduto()
        {
            InitializeComponent();
        }

        private void btnExcluirProduto_Click(object sender, EventArgs e)
        {
            //botao excluir produto

            Produto obj = new Produto();
            obj.nomeProduto = txtNomeProduto.Text;

            //2 passo -Criar o objeto DAO
            ProdutoDAO dao = new ProdutoDAO();  
            dao.ExcluirProduto(obj);



            //recarregar datagridview
            DataGridViewVendas.DataSource = dao.LIstarProdutos();
        }

        private void DataGridViewVendas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DataGridViewVendas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //Pegando os dados do produto selecionado
            txtNomeProduto.Text = DataGridViewVendas.CurrentRow.Cells[1].Value.ToString();
            
        }

        private void FrmADMExcluirProduto_Load(object sender, EventArgs e)
        {
            //puxando o metodo listar produto
            ProdutoDAO dao = new ProdutoDAO();
            DataGridViewVendas.DataSource = dao.LIstarProdutos();

            Cursor.Current = Cursors.Arrow;
        }

        private void txtPesquisa_TextChanged(object sender, EventArgs e)
        {
            string nome = "%" + txtPesquisa.Text + "%";
            ProdutoDAO dao = new ProdutoDAO();

            DataGridViewVendas.DataSource = dao.LIstarProdutosPorNome(nome);

        }

        private void txtNomeProduto_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnX_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
