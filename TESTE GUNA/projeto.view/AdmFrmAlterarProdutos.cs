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
            //puxando o metodo listar produto
            ProdutoDAO dao = new ProdutoDAO();
            DataGridViewVendas.DataSource = dao.LIstarProdutos();
        }

        private void btnSalvarAlteracoes_Click(object sender, EventArgs e)
        {
            //Botao Alterar Produto

            //ProdutoDAO dao = new ProdutoDAO();
            //Validador validade = new Validador();
            //var precoentrada = Convert.ToDecimal(txtPreco.Text);
            //txtPreco.Text = precoentrada.ToString("N2");

            //string nome = txtNomeProduto.Text;
            Produto obj = new Produto();
            obj.nomeProduto =txtNomeProduto.Text;
            obj.precoProduto = decimal.Parse(txtPreco.Text);
            obj.qtdEstoque = Convert.ToInt32(txtQuantidade.Text);
           
            ProdutoDAO dao = new ProdutoDAO();
            dao.AlterarProduto(obj);

            new Helpers().LimparTela(this);

            //Recarregar o datagridview 

            DataGridViewVendas.DataSource =dao.LIstarProdutos();



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
            txtNomeProduto.Text = "";
        }

        private void txtPreco_Click(object sender, EventArgs e)
        {
            txtPreco.Text = "";
        }

        private void txtQuantidade_Click(object sender, EventArgs e)
        {
            txtQuantidade.Text = "";
        }

        private void DataGridViewVendas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DataGridViewVendas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //Pegando os dados do produto selecionado
            txtNomeProduto.Text= DataGridViewVendas.CurrentRow.Cells[1].Value.ToString();
            txtPreco.Text = DataGridViewVendas.CurrentRow.Cells[3].Value.ToString();
            txtQuantidade.Text = DataGridViewVendas.CurrentRow.Cells[4].Value.ToString();
        }

        private void txtPesquisa_TextChanged(object sender, EventArgs e)
        {
            string nome = "%" + txtPesquisa.Text + "%";
            ProdutoDAO dao =new ProdutoDAO();

            DataGridViewVendas.DataSource = dao.LIstarProdutosPorNome(nome);
        }
    }
}
