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

        
        
        private string _nome;
        private string _desc;
        private decimal _preco;
        private string _dep;


        [Category("Custom Props")]
        public string NomeProduto
        {
            get { return _nome; }
            set { _nome = value; labelNome.Text = value; }
        }



        [Category("Custom Props")]
        public string Desc
        {
            get { return _desc; }
            set { _desc = value; labelDescricao.Text = value; }
        }

        [Category("Custom Props")]
        public string Dep
        {
            get { return _dep; }
            set { _dep = value; labeldep.Text = value; }
        }

        [Category("Custom Props")]
        public Decimal Preco
        {
            get { return _preco; }
            set { _preco = value; labelPreco.Text = value.ToString(); }
        }

        private void UserControlProduto_Load(object sender, EventArgs e)
        {

        }


        private void labelNome_Click(object sender, EventArgs e)
        {
            
        }
        //atraves do ID do produto printar as info sobre o produto
        //public void PrintarProduto(int IDProduto)
        //{

        //    //recebe as informações
        //    labelNome.Text = "Nome do produto";
        //    labelDescricao.Text = "Descrição do produto";
        //    labelPreco.Text = "RS 00,00";


        //}

        private void UserControlProduto_Click(object sender, EventArgs e)
        {

            // Redirecionar para a tela de compras
            AdicionarAvancar telaconfirmar = new AdicionarAvancar();
            telaconfirmar.labelProduto.Text = labelNome.Text;
            telaconfirmar.labelDesc.Text = labelDescricao.Text;
            telaconfirmar.labelValor.Text = labelPreco.Text;


            telaconfirmar.Show();

            


        }

        private void imagemProduto_Click(object sender, EventArgs e)
        {

        }

        private void labelDescricao_Click(object sender, EventArgs e)
        {
            
        }

        private void labelcodigo_Click(object sender, EventArgs e)
        {

        }
    }
}
