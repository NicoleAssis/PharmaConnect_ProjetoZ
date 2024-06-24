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
    public partial class AdicionarAvancar : Form
    {
        private int qtd;
        public AdicionarAvancar()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void labelDesc_Click(object sender, EventArgs e)
        {

        }

        public void panel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {

        }

        private void guna2ContainerControl4_Click(object sender, EventArgs e)
        {

        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            this.Close();
            


        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btncomprar_Click(object sender, EventArgs e)
        {
            
            

        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            qtd++; 
            txtqtd.Text = qtd.ToString();
        }

        private void txtqtd_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btndiminuir_Click(object sender, EventArgs e)
        {
            qtd--;
            txtqtd.Text = qtd.ToString();
        }
    }
}
