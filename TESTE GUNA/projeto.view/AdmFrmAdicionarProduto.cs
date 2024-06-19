using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;
using TESTE_GUNA.projet.conexao;
using TESTE_GUNA.projeto.model;
using TESTE_GUNA.projeto.dao;

namespace TESTE_GUNA.projeto.view
{
    public partial class AdmFrmAdicionarProduto : Form
    {
        public AdmFrmAdicionarProduto()
        {
            InitializeComponent();
        }

        private void btnX_Click(object sender, EventArgs e)
        {
            //button fechar o programa (X)
            this.Close();
        }


        private void txtNomeCartao_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNomeCartao_Click(object sender, EventArgs e)
        {
            txtNomeProduto.Text = "";
        }

        private void txtPreco_Click(object sender, EventArgs e)
        {
            
        }

        private void txtQuantidade_Click(object sender, EventArgs e)
        {
            
        }

        private void btnCriarProduto_Click(object sender, EventArgs e)
        {

            var precoentrada = Convert.ToDecimal(txtPreco.Text);
            txtPreco.Text = precoentrada.ToString("N2"); 
            
            string nome = txtNomeProduto.Text;
            string desc = txtDescricao.Text;
            int quantidadeEstoque = int.Parse(txtQuantidade.Text);
            decimal precoUnitProduto = decimal.Parse(txtPreco.Text);
            string dep = cbDepartamentos.Text;
            FrmMessageBox mensagem = new FrmMessageBox();
            

            mensagem.Mensagem("PRODUTO CRIADO COM SUCESSO!");
            mensagem.ShowDialog();




            Produto obj = new Produto()
            {
                nomeProduto = txtNomeProduto.Text,
                descProduto = TxtDesc.Text,
                precoProduto = decimal.Parse(txtPreco.Text),
                qtdEstoque = Convert.ToInt32(txtQuantidade),
                departamento = cbDepartamentos.SelectedIndex.ToString()
            };


            ProdutoDAO dao = new ProdutoDAO();
            dao.CadastrarProduto(obj);



        }
    }
}
