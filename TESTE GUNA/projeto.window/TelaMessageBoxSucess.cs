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
    public partial class TelaMessageBoxSucess : Form
    {
        public TelaMessageBoxSucess()
        {
            InitializeComponent();
        }

        public void Mensagem(string mensagem)
        {
            txtMensagem.Text = mensagem;
        }


        private void TelaMessageBoxSucess_Load(object sender, EventArgs e)
        {

        }

        private void btnX_Click(object sender, EventArgs e)
        {
            //button fechar a tela de pagamento
            this.Close();
        }
    }
}
