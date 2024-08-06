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
    public partial class FrmPagamento : Form
    {
        public FrmPagamento()
        {
            InitializeComponent();
        }

        public string pagEscolhido;

        private void btnX_Click(object sender, EventArgs e)
        {
            //button fechar a tela de pagamento
            this.Close();
        }

        //IR PARA A TELA DO PAGAMENTO DESEJADO
        private void btnEscolherPagamento_Click(object sender, EventArgs e)
        {
            if (checkBoxCredito.Checked)
            {
                //abre a tela de credito
                FrmPagCredito telaCredito = new FrmPagCredito("Credito");
                this.Close();
                telaCredito.ShowDialog();

            }
            else if (checkBoxDebito.Checked)
            {
                //abre a tela de debito
                FrmPagDebito telaDebito = new FrmPagDebito();
                this.Close();
                telaDebito.ShowDialog();

            }
            else if (checkBoxPix.Checked)
            {
                //abre a tela de pix
                FrmPagPix frmPagPix = new FrmPagPix();
                this.Close();
                frmPagPix.ShowDialog();
            }
            else
            {
                //caso nao seja selecionado nenhum pagamento
                TelaMessageBox TelaMessageBox = new TelaMessageBox();
                TelaMessageBox.Mensagem("SELECIONE O TIPO DE PAGAMENTO");
                TelaMessageBox.ShowDialog();
            }
        }

        private void FrmPagamento_Load(object sender, EventArgs e)
        {
              


        }

        private void checkBoxCredito_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
