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
        private TelaHome telaHome;

        public TelaCompras(TelaHome home)
        {
            InitializeComponent();
            this.telaHome = home;
            this.DoubleBuffered = true;//parar de travar a tela
        }

        #region PrintarTela

        public void PrintarTela(Form form)
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

        public void PrintarTelaPagamento()
        {
            TelaPagamento telaPagamento = new TelaPagamento(this);
            PrintarTela(telaPagamento);
            telaPagamento.BringToFront();
        }
        public void PrintarTelaFinalizarPagamento()
        {
            TelaFinalizarPagamento tela = new TelaFinalizarPagamento(this);
            PrintarTela(tela);
            tela.BringToFront();
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
            TelaFrete tela = new TelaFrete(this);
            PrintarTela(tela);
            tela.BringToFront();
        }

        //continuar comprando
        private void btnIrParaCarrinho_Click(object sender, EventArgs e)
        {
            TelaProdutos telaProdutos = new TelaProdutos(this.telaHome);
            this.telaHome.PrintarTelaForaDaHome(telaProdutos);
        }
    }
}
