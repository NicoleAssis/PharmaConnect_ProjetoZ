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
            FrmMessageBox frmMessageBox = new FrmMessageBox();
            frmMessageBox.RetornaSimNao("DESEJA ADICIONAR AO CARRINHO?");
            frmMessageBox.ShowDialog();

            if (frmMessageBox.btnSimClick == true)
            {
                // Se confirmou que deseja adicionar ao carrinho
                frmMessageBox.Mensagem("PRODUTO ADICIONADO COM SUCESSO");
                frmMessageBox.ShowDialog();

                

                // Abrir a tela de compras
                FrmCompras telaCompras = new FrmCompras();
                telaCompras.ShowDialog();


            }
            else if (frmMessageBox.btnNaoClick == true)
            {
                // Se não quer efetuar o pagamento, apenas ir para a tela de compras
                frmMessageBox.Close(); // Fechar a caixa de mensagem
                this.Hide(); // Esconder o formulário atual
                
            }
            else
            {
                // Se não selecionou SIM ou NÃO
                frmMessageBox.Mensagem("Selecione SIM ou NAO");
            }


        }

        private void imagemProduto_Click(object sender, EventArgs e)
        {

        }

        private void labelDescricao_Click(object sender, EventArgs e)
        {

        }
    }
}
