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
using TESTE_GUNA.projeto.view;

namespace TESTE_GUNA.projeto.window
{
    public partial class TelaPagamento : Form
    {
        //printar a proxima tela
        private TelaCompras _telaCompras;
        public TelaPagamento(TelaCompras telaCompras)
        {
            InitializeComponent();
            this.DoubleBuffered = true; // parar de travar a tela
            _telaCompras = telaCompras;
        }

        public static int FormaPagamento;
        private void txtCVV_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void TelaPagamento_Load(object sender, EventArgs e)
        {

        }

        private void btnContinuar_Click(object sender, EventArgs e)
        {
            _telaCompras.PrintarTelaFinalizarPagamento();
        }

        private void checkBoxPIX_CheckedChanged(object sender, EventArgs e)
        {
            if (panelPagamentoCartao.Visible = true)
            {
                panelPagamentoCartao.Visible = false;
                txtAno.Text = "";
                txtCVV.Text = "";
                txtMes.Text = "";
                txtNomeCartao.Text = "";
                txtNumeroCartao.Text = "";

                panelPagamentoPIX.Visible = true;
            }
            else
            {
                panelPagamentoPIX.Visible = true;
            }

            FormaPagamento = 1;

            
        }

        private void checkBoxDebito_CheckedChanged(object sender, EventArgs e)
        {
            if (panelPagamentoPIX.Visible = true)
            {
                panelPagamentoPIX.Visible = false;

                panelPagamentoCartao.Visible = true;
            }
            else
            {
                panelPagamentoCartao.Visible = true;
            }

            FormaPagamento = 2;
        }

        private void checkBoxCredito_CheckedChanged(object sender, EventArgs e)
        {
            if (panelPagamentoPIX.Visible = true)
            {
                panelPagamentoPIX.Visible = false;

                panelPagamentoCartao.Visible = true;
            }
            else
            {
                panelPagamentoCartao.Visible = true;
            }
            FormaPagamento = 3;
        }

        private void btnCopiar_Click(object sender, EventArgs e)
        {

        }
    }
}
