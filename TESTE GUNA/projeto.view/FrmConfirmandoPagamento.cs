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

namespace TESTE_GUNA.projeto.view
{
    public partial class FrmConfirmandoPagamento : Form
    {
        public FrmConfirmandoPagamento()
        {
            InitializeComponent();
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
                

                FrmMessageSucess mensagemSucesso = new FrmMessageSucess();
                mensagemSucesso.MensagemDeSucesso("COMPRA EFETUADA COM SUCESSO!");
                mensagemSucesso.ShowDialog();

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
    }
}
