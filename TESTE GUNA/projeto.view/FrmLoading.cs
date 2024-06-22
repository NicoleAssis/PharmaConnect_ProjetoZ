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
    public partial class FrmLoading : Form
    {
        public FrmLoading()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(progressBar.Value == 100)
            {
                timer1.Stop();
                FrmLogin telaLogin = new FrmLogin();
                telaLogin.Show();

                this.Hide();
            }
            else
            {
                progressBar.Value += 2;
                label1.Text = (Convert.ToInt32(label1.Text) + 2).ToString();
            }


        }

        private void FrmLoading_Load(object sender, EventArgs e)
        {
            guna2ShadowForm1.SetShadowForm(this);
            timer1.Start();
        }
    }
}
