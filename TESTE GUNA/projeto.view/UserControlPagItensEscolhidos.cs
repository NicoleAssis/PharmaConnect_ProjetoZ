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
    public partial class UserControlPagItensEscolhidos : UserControl
    {
        public UserControlPagItensEscolhidos()
        {
            InitializeComponent();
        }

        public void PrintarProduto(int IDProduto)
        {
            lblNome.Text = "Nome Produto";
            lblDescricao.Text = "Descrição do Produto";
            lblQtd.Text = "5";

            decimal preco = 35;
            decimal qnt = decimal.Parse(lblQtd.Text);
            decimal subtotal = preco * qnt;
            lblSubtotal.Text = subtotal.ToString();
        }



        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void labelNome_Click(object sender, EventArgs e)
        {
            
        }

        private void labelQtd_Click(object sender, EventArgs e)
        {

        }

        private void UserControlPagItensEscolhidos_Load(object sender, EventArgs e)
        {

        }
    }
}
