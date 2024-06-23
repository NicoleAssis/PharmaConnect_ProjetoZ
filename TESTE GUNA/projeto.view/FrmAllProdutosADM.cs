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


namespace TESTE_GUNA.projeto.view
{
    public partial class TabelaProdutos : Form
    {
        public TabelaProdutos()
        {
            InitializeComponent();
            
        }
        //SampleView

        private void guna2Panel2_Paint(object sender, PaintEventArgs e)
        {
        }

        private void FrmAllProdutosADM_Load(object sender, EventArgs e)
        {
            ProdutoDAO dao = new ProdutoDAO();
            guna2DataGridView1.DataSource = dao.ListarProdutos();
            
            
        }

        public virtual void btnAdd_Click(object sender, EventArgs e)
        {

        }


        public virtual void txtPesquisar_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2Separator1_Click(object sender, EventArgs e)
        {

        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }
    }
}
