using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TESTE_GUNA.projeto.window
{
    public partial class UserControlCarrinho : UserControl
    {

        static int addDiminuitMaleavel;

       


        public UserControlCarrinho()
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
























        private void RSMoeda_Click(object sender, EventArgs e)
        {

        }

        private void txtPreco_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void guna2Panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
