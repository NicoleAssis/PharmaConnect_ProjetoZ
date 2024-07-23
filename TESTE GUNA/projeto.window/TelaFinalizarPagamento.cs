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
        private TelaHome telaHome;

        public TelaFinalizarPagamento(TelaCompras telaCompras, TelaHome home)
        {
            InitializeComponent();
            this.DoubleBuffered = true; // parar de travar a tela
            _telaCompras = telaCompras;
            telaHome = home;
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
                this.telaHome.Hide();
                TelaConfirmandoPagamento telaConfirmando = new TelaConfirmandoPagamento(this.telaHome);
                telaConfirmando.ShowDialog();
                this.telaHome.Show();
            }
            else if (messageBox.btnNaoClick == true)
            {
                this.Close();
                TelaCompras telaCompras = new TelaCompras(this.telaHome);
                this.telaHome.PrintarTelaForaDaHome(telaCompras);
            }
            else
            {
                messageBox.Mensagem("Selecione SIM ou NAO");
            }
           
        }
    }
}
