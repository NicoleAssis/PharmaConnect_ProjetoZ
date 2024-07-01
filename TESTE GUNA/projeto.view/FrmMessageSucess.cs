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
    public partial class FrmMessageSucess : Form
    {
        public FrmMessageSucess()
        {
            InitializeComponent();
        }


        private void btnX_Click(object sender, EventArgs e)
        {
            //button fechar a tela de pagamento
            this.Close();
        }

        private void FrmMessageSucess_Load(object sender, EventArgs e)
        {

        }

        public void MensagemDeSucesso(string mensagem)
        {
            lblTexto.Text = mensagem;

        }
    }
}
