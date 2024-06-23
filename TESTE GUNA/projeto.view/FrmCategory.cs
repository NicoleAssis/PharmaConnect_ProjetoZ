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
    public partial class FrmCategory : TabelaProdutos 
    { 
        public FrmCategory()
        {
            InitializeComponent();
        }

        public  void FrmCategory_Load(object sender, EventArgs e)
        {

        }
        //Override garante que código está sendo sobreescrivido e não criado um novo

        public override void btnAdd_Click(object sender, EventArgs e)
        {

        }

        public override void txtPesquisar_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
