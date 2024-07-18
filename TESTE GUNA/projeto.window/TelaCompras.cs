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
    public partial class TelaCompras : Form
    {
        public TelaCompras()
        {
            InitializeComponent();
            this.DoubleBuffered = true;//parar de travar a tela
        }

        #region PrintarTela

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

        #endregion

        private void TelaCompras_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnEfetuarCompra_Click(object sender, EventArgs e)
        {
            //criar uma tela antes do frete
            TelaFrete tela = new TelaFrete();
            PrintarTela(tela);
            tela.BringToFront();
        }
    }
}
