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
using TESTE_GUNA.projeto.model;
using TESTE_GUNA.projeto.view;

namespace TESTE_GUNA.projeto.window
{
    public partial class TelaFinalizarPagamento : Form
    {
        //printar a proxima tela
        private TelaCompras _telaCompras;
        public TelaFinalizarPagamento(TelaCompras telaCompras)
        {
            InitializeComponent();
            this.DoubleBuffered = true; // parar de travar a tela
            _telaCompras = telaCompras;
        }


        private void TelaFinalizarPagamento_Load(object sender, EventArgs e)
        {

        }

        private void btnContinuar_Click(object sender, EventArgs e)
        {
            //pergunta se deseja efetuar o pagamento ou nao
            TelaMessageBox messageBox = new TelaMessageBox();
            messageBox.RetornaSimNao("DESEJA EFETUAR O PAGAMENTO?");
            messageBox.ShowDialog();

            if (messageBox.btnSimClick == true)
            {
                this.Close();
                TelaConfirmandoPagamento tela = new TelaConfirmandoPagamento();
                tela.ShowDialog();
                tela.BringToFront();
            }
            else if (messageBox.btnNaoClick == true)
            {
                //se nao quer efetuar o pagamento
                this.Close();


            }
            else
            {
                messageBox.Mensagem("Selecione SIM ou NAO");
            }
           
        }
    }
}
