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
    public partial class SampleADD : Form
    {
        public SampleADD()
        {
            InitializeComponent();
        }

        public int id = 0;
        public virtual void BtnSalvar_Click(object sender, EventArgs e)
        {
            
        }

        public virtual void BtnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void SampleADD_Load(object sender, EventArgs e)
        {

        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
