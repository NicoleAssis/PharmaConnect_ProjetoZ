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

        public string TipoDePagamento { get; set; }

        public FrmPagCredito(string pagamento)
        {
            InitializeComponent();
            TipoDePagamento = pagamento;
        }

        private void btnX_Click(object sender, EventArgs e)
        {
            //button fechar a tela de pagamento
            this.Close();
        }

        private void btnSalvarAlteracoes_Click(object sender, EventArgs e)
        {
            if(txtAno.Text == "" || txtCartao.Text == "" || txtCVV.Text == "" || txtMes.Text == "" || txtNomeCartao.Text == "")
            {
                FrmMessageBox message = new FrmMessageBox();
                message.Mensagem("PREENCHA TODOS OS CAMPOS!");
                message.ShowDialog();
            }
            else
            {
                //abrir tela finalizar pagamento
                FrmPagFinalizar telaFinalizar = new FrmPagFinalizar("Credito", txtCartao.Text, txtNomeCartao.Text, txtMes.Text, txtAno.Text, txtCVV.Text);
                this.Close();
                telaFinalizar.ShowDialog();
            }
            

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
