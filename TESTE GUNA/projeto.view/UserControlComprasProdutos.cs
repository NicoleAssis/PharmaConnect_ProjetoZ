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
    public partial class UserControlComprasProdutos : UserControl
    {
        public UserControlComprasProdutos()
        {
            InitializeComponent();
        }

        public void printarProduto(int IDProduto)
        {
            lblNome.Text = "Nome Produto";
            lblDescricao.Text = "Descrição do Produto";
            lblPreco.Text = "35,00";

            decimal preco = decimal.Parse(lblPreco.Text);
            decimal qnt = decimal.Parse(txtQuantidade.Text);
            decimal subtotal = preco * qnt;
            lblSubtotal.Text = subtotal.ToString();

            
        }



        private void labelDescricao_Click(object sender, EventArgs e)
        {

        }

        private void btnMais_Click(object sender, EventArgs e)
        {
            int valorAtual = Convert.ToInt32(txtQuantidade.Text);
            // Incrementa o valor
            valorAtual++;
            // Atualiza o valor do TextBox
            txtQuantidade.Text = valorAtual.ToString();
            decimal subtotal = Convert.ToDecimal(lblSubtotal.Text) + Convert.ToDecimal(lblPreco.Text);
            
            lblSubtotal.Text = subtotal.ToString();

        }

        private void btnMenos_Click(object sender, EventArgs e)
        {
            int valorAtual = Convert.ToInt32(txtQuantidade.Text);
            // Incrementa o valor
            if (valorAtual > 0)
            {
                valorAtual--;

                decimal preco = Convert.ToDecimal(lblPreco.Text);
                decimal subtotal = Convert.ToDecimal(lblSubtotal.Text);
                subtotal = subtotal - preco;

                // Atualiza o valor do TextBox
                txtQuantidade.Text = valorAtual.ToString();
                lblSubtotal.Text = subtotal.ToString();
            }
            if(valorAtual <= 0)
            {
                //pergunta se deseja efetuar o pagamento ou nao
                FrmMessageBox frmMessageBox = new FrmMessageBox();
                frmMessageBox.RetornaSimNao("DESEJA DELETAR O PRODUTO?");
                frmMessageBox.ShowDialog();

                if (frmMessageBox.btnSimClick == true)
                {
                    //se confirmou que deseja deletar o produto
                    FrmCompras telaCompras = new FrmCompras();
                    telaCompras.DeletarProduto(this);

                    panel10.Size = new Size(1, 1);
                    panel10.Visible= false;

                    frmMessageBox.Mensagem("PRODUTO DELETADO COM SUCESSO!");
                    frmMessageBox.ShowDialog();
                }
                else if (frmMessageBox.btnNaoClick == true)
                {
                    //se nao quer efetuar o pagamento
                    valorAtual = 1;
                    txtQuantidade.Text = "1";
                }
                else
                {
                    frmMessageBox.Mensagem("Selecione SIM ou NAO");
                }
            }
            
        }

        private void labelNome_Click(object sender, EventArgs e)
        {

        }

        private void panel10_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
