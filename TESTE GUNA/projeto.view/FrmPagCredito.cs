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
    public partial class FrmPagCredito : Form
    {
        public FrmPagCredito()
        {
            InitializeComponent();
        }

        private void btnX_Click(object sender, EventArgs e)
        {
            //button fechar a tela de pagamento
            this.Close();
        }

        private void btnSalvarAlteracoes_Click(object sender, EventArgs e)
        {
            if(txtAno.Text == "" || txtCartao.Text == "" || txtCVV.Text == "" ||)
            {

            }
            
            //abrir tela finalizar pagamento
            FrmPagFinalizar telaFinalizar = new FrmPagFinalizar();
            this.Close();
            telaFinalizar.ShowDialog();
        }

        private void FrmPagCredito_Load(object sender, EventArgs e)
        {

        }

        private void txtNomeCartao_Click(object sender, EventArgs e)
        {
            txtNomeCartao.Text = " ";
        }
    }
}
