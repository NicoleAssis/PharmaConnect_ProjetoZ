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
    public partial class FrmPagDebito : Form
    {
        public FrmPagDebito()
        {
            InitializeComponent();
        }

        private void btnX_Click(object sender, EventArgs e)
        {
            //button fechar a tela de pagamento
            this.Close();
        }

        private void txtEstado_TextChanged(object sender, EventArgs e)
        {

        }

        private void FrmPagDebito_Load(object sender, EventArgs e)
        {

        }

        private void btnSalvarInfo_Click(object sender, EventArgs e)
        {
            //abrir tela finalizar pagamento
            FrmPagFinalizar telaFinalizar = new FrmPagFinalizar();
            this.Close();
            telaFinalizar.ShowDialog();
        }

        private void txtNomeCartao_Click(object sender, EventArgs e)
        {
            txtNomeCartao.Text = " ";
        }
    }
}
