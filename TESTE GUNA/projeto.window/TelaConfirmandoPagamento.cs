using Guna.UI2.WinForms;
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
    public partial class TelaConfirmandoPagamento : Form
    {
        private TelaHome telaHome;

        public TelaConfirmandoPagamento(TelaHome home)
        {
            InitializeComponent();
            this.telaHome = home;
            this.DoubleBuffered = true;//parar de travar a tela
        }


        private void FrmConfirmandoPagamento_Load(object sender, EventArgs e)
        {
            guna2ShadowForm1.SetShadowForm(this);
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (progressBar.Value == 100)
            {
                timer1.Stop();

                TelaMessageBoxSucess messageBox = new TelaMessageBoxSucess();
                messageBox.Mensagem("COMPRA FEITA COM SUCESSO!");
                messageBox.ShowDialog();

                TelaProdutos telaProdutos = new TelaProdutos(this.telaHome);
                this.telaHome.PrintarTelaForaDaHome(telaProdutos);

                this.Close();
            }
            else
            {
                progressBar.Value += 2;
                label5.Text = (Convert.ToInt32(label5.Text) + 2).ToString();
            }
        }

        private void numeroLabel_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void progressBar_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
