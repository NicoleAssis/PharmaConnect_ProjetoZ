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
    public partial class Teste : Form
    {
        public Teste()
        {
            InitializeComponent();
        }

        private void PrintarTela(Form form)
        {
            if (this.panelAbrirTela.Controls.Count > 0)
                this.panelAbrirTela.Controls.RemoveAt(0);

            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            this.panelAbrirTela.Controls.Add(form);
            this.panelAbrirTela.Tag = form;
            form.Show();
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnX_Click(object sender, EventArgs e)
        {

        }

        private void btnLimparCarrinho_Click(object sender, EventArgs e)
        {

        }

        private void btnPagamento_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void btnComprasFinalizadas_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox15_Click(object sender, EventArgs e)
        {

        }

        private void Teste_Load(object sender, EventArgs e)
        {
            TelaProdutos tela = new TelaProdutos();
            PrintarTela(tela);
            tela.BringToFront();
        }
    }
}
