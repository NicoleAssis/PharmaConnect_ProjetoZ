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

        public string TipoDePagamento { get; set; }

        public FrmPagDebito(string pagamento)
        {
            InitializeComponent();
            TipoDePagamento = pagamento;
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
            if (txtAno.Text == "" || txtCartao.Text == "" || txtCVV.Text == "" || txtMes.Text == "" || txtNomeCartao.Text == "")
            {
                FrmMessageBox message = new FrmMessageBox();
                message.Mensagem("PREENCHA TODOS OS CAMPOS!");
                message.ShowDialog();
            }
            else
            {
                //abrir tela finalizar pagamento
                FrmPagFinalizar telaFinalizar = new FrmPagFinalizar("Debito", txtCartao.Text, txtNomeCartao.Text, txtMes.Text, txtAno.Text, txtCVV.Text);
                this.Close();
                telaFinalizar.ShowDialog();
            }

        }

        private void txtNomeCartao_Click(object sender, EventArgs e)
        {
            txtNomeCartao.Text = " ";
        }
    }
}
