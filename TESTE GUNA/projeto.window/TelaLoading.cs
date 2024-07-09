using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TESTE_GUNA.projeto.window;
using System.Windows.Forms;

namespace TESTE_GUNA.projeto.window
{
    public partial class TelaLoading : Form
    {
        public TelaLoading()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (progressBar.Value == 100)
            {
                timer1.Stop();
                TelaLogin telaLogin = new TelaLogin();
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

        private void progressBar_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
