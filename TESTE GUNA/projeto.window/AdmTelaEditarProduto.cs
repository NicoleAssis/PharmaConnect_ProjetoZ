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
    public partial class txtQtdEstoque : Form
    {
        public txtQtdEstoque()
        {
            InitializeComponent();
        }

        private void btnX_Click(object sender, EventArgs e)
        {
            //button fechar a tela de pagamento
            this.Close();
        }

        private void txtMensagem_Click(object sender, EventArgs e)
        {

        }

        private void btnAlterarSenha_Click(object sender, EventArgs e)
        {
            int id = AdmTelaProdutos.idProduto;
            ProdutoDAO dao = new ProdutoDAO();
            Produto obj = new Produto()
            {
                Id_Produto = id,
                nomeProduto = txtNome.Text,
                descProduto = txtDescricao.Text,
                precoProduto = Convert.ToDecimal(txtPreco.Text),
                qtdEstoque = Convert.ToInt32(guna2TextBox1.Text),
                departamento =  boxCategoria.SelectedItem.ToString()


             };
            try
            {
                dao.updateProduct(obj);
            }
            catch (Exception)
            {
                TelaMessageBoxSucess mensagem = new TelaMessageBoxSucess();
                mensagem.Mensagem("Erro ao Cadastrar!");
                mensagem.ShowDialog();
            }
            
            
            
            this.Close();
        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void boxCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
