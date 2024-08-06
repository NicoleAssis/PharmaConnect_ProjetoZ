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

        //public void printarProduto(int IDProduto)
        //{


        //    decimal preco = decimal.Parse(llabeltotal.Text);
        //    decimal qnt = decimal.Parse(txtqtd.Text);
        //    decimal subtotal = preco * qnt;
        //    llabeltotal.Text = subtotal.ToString();

            
        //}



        private void labelDescricao_Click(object sender, EventArgs e)
        {

        }

        private void btnMais_Click(object sender, EventArgs e)
        {
            int valorAtual = Convert.ToInt32(txtqtd.Text);
            // Incrementa o valor
            valorAtual++;
            // Atualiza o valor do TextBox
            txtqtd.Text = valorAtual.ToString();
            decimal subtotal = Convert.ToDecimal(llabeltotal.Text) + Convert.ToDecimal(llabeltotal.Text);
            
            llabeltotal.Text = subtotal.ToString();

        }

        private void btnMenos_Click(object sender, EventArgs e)
        {
            int valorAtual = Convert.ToInt32(llabeltotal.Text);
            // Incrementa o valor
            if (valorAtual > 0)
            {
                valorAtual--;

                decimal preco = Convert.ToDecimal(llabeltotal.Text);
                decimal subtotal = Convert.ToDecimal(llabeltotal.Text);
                subtotal = subtotal - preco;

                // Atualiza o valor do TextBox
                txtqtd.Text = valorAtual.ToString();
                llabeltotal.Text = subtotal.ToString();
            }
            if(valorAtual <= 0)
            {
                //pergunta se deseja efetuar o pagamento ou nao
                TelaMessageBox TelaMessageBox = new TelaMessageBox();
                TelaMessageBox.RetornaSimNao("DESEJA DELETAR O PRODUTO?");
                TelaMessageBox.ShowDialog();

                if (TelaMessageBox.btnSimClick == true)
                {
                    //se confirmou que deseja deletar o produto
                    FrmCompras telaCompras = new FrmCompras();
                    telaCompras.DeletarProduto(this);

                    panel10.Size = new Size(1, 1);
                    panel10.Visible= false;

                    TelaMessageBox.Mensagem("PRODUTO DELETADO COM SUCESSO!");
                    TelaMessageBox.ShowDialog();
                }
                else if (TelaMessageBox.btnNaoClick == true)
                {
                    //se nao quer efetuar o pagamento
                    valorAtual = 1;
                    txtqtd.Text = "1";
                }
                else
                {
                    TelaMessageBox.Mensagem("Selecione SIM ou NAO");
                }
            }
            
        }

        private void labelNome_Click(object sender, EventArgs e)
        {

        }

        private void panel10_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2ContextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }
    }
}
