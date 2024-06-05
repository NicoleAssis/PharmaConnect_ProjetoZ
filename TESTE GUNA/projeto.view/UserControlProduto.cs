using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TESTE_GUNA.projeto.view
{
    public partial class UserControlProduto : UserControl
    {
        public UserControlProduto()
        {
            InitializeComponent();
        }

        private string labelProduto;

        public string NomeProduto
        {
            get { return labelProduto; }
            set { labelProduto = value; labelNome.Text = value; }
        }

        //atraves do ID do produto printar as info sobre o produto
        public void PrintarProduto(int IDProduto)
        {
            //recebe as informações
            labelNome.Text = "Nome do produto";
            labelDescricao.Text = "Descrição do produto";
            labelPreco.Text = "RS 00,00";


        }

        private void UserControlProduto_Load(object sender, EventArgs e)
        {

        }

        private void labelNome_Click(object sender, EventArgs e)
        {

        }

        private void UserControlProduto_Click(object sender, EventArgs e)
        {


            // Redirecionar para a tela de compras
            FrmCompras telaCompras = new FrmCompras();
            telaCompras.Show();

            // Esconder o formulário atual (se necessário)
            this.Hide();

        }

        private void imagemProduto_Click(object sender, EventArgs e)
        {

        }
    }
}
