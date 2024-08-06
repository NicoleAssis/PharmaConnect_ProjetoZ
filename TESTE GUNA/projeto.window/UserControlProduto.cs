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
    public partial class UserControlProduto : UserControl
    {
        public UserControlProduto()
        {
            InitializeComponent();
        }

        
        #region Propriedades
        
        private string _nomeProduto;
        private string _preco;
        private string _descProduto;
        private string _idcodigo;

        [Category("Custom Pro")]
        public string Produto
        {
            get { return _nomeProduto; }
            set { _nomeProduto = value; txtNome.Text = value; }
        }

        [Category("Custom Pro")]
        public string Codigo
        {
            get { return _idcodigo; }
            set { _idcodigo = value; txtcodigo.Text = value; }
        }


        [Category("Custom Pro")]
        public string Descricao
        {
            get { return _descProduto; }
            set { _descProduto = value; txtDescricao.Text = value; }
        }



        [Category("Custom Pro")]
        public string PrecoProduto
        {
            get { return _preco; }
            set { _preco = value; txtPreco.Text = value; }
        }



        #endregion





        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnAdicionarCarrinho_Click(object sender, EventArgs e)
        {
            //pergunta se deseja efetuar o pagamento ou nao
            TelaMessageBox messageBox = new TelaMessageBox();
            messageBox.RetornaSimNao("DESEJA ADICIONAR "+ _nomeProduto +" AO CARRINHO?");
            messageBox.ShowDialog();

            int qtd_estoque, qtdComprada, estoqueAtualizado;

            if (messageBox.btnSimClick == true)
            {

                int id_Conexao = ClienteDAO.id_conectado;

                CarrinhoDAO dao = new CarrinhoDAO();

                CarrinhoDAO obj = new CarrinhoDAO
                {
                    id_produtoCarrinho = Convert.ToInt32(Codigo),
                    id_cliente = id_Conexao,
                    qtd_Carrinho = 1,
                    subtotalCarrinho = Convert.ToDecimal(PrecoProduto),
                    totalCarrinho = (1 * Convert.ToDecimal(PrecoProduto)),

                };

                dao.CadastrarProdutoCarrinho(obj);
            }
            else
            {
                messageBox.Close();
            }

        }

        public void DetailsB(Produto d)
        {
            Produto = d.nomeProduto;
            Descricao = d.descProduto;
            PrecoProduto = d.precoProduto.ToString();
            Codigo = d.Id_Produto.ToString();
        }

        public void searchResult(string key)
        {
            ProdutoDAO get = new ProdutoDAO();
            get.Search(key);

            Produto = get.nomeProduto;
            Descricao = get.descProduto;
            PrecoProduto = get.precoProduto.ToString();
            Codigo = get.Id_Produto.ToString();
        }
        public void searchResultDEP(string key)
        {
            ProdutoDAO get = new ProdutoDAO();
            get.SearchDepartamento(key);

            Produto = get.nomeProduto;
            Descricao = get.descProduto;
            PrecoProduto = get.precoProduto.ToString();
            Codigo = get.Id_Produto.ToString();
        }

        private void txtDescricao_Click(object sender, EventArgs e)
        {

        }
    }
}