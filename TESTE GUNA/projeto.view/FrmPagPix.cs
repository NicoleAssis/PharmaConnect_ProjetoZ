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
    public partial class FrmPagPix : Form
    {
        public FrmPagPix()
        {
            InitializeComponent();
        }

        private void FrmPagPix_Load(object sender, EventArgs e)
        {

        }

        private void btnSalvarInfo_Click(object sender, EventArgs e)
        {

            //abrir tela finalizar pagamento
            FrmPagFinalizar telaFinalizar = new FrmPagFinalizar("Pix", "Pix", "Pix", "Pix", "Pix", "Pix");
            this.Close();
            telaFinalizar.ShowDialog();

        }

        private void btnX_Click(object sender, EventArgs e)
        {
            //button fechar a tela de pagamento
            this.Close();
        }

        private void btnCopiar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtPix.Text))
            {
                // Copiar o texto da TextBox para a área de transferência
                Clipboard.SetText(txtPix.Text);
                FrmMessageBox message = new FrmMessageBox();
                message.Mensagem("Texto copiado para a área de transferência!");
                message.ShowDialog();

            }
            else
            {
                FrmMessageBox message = new FrmMessageBox();
                message.Mensagem("A TextBox está vazia, nada para copiar.");
                message.ShowDialog();
            }
        }
    }
}
