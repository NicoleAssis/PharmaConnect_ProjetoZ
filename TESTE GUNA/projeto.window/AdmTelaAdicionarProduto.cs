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
    public partial class AdmTelaAdicionarProduto : Form
    {
        private AdmTelaHome admHome;

        public AdmTelaAdicionarProduto(AdmTelaHome home)
        {
            InitializeComponent();
            this.admHome = home;
            this.DoubleBuffered = true;//parar de travar a tela
        }

        private void btnAdicionarProduto_Click(object sender, EventArgs e)
        {
            TelaMessageBoxSucess messageBoxSucess = new TelaMessageBoxSucess();
            messageBoxSucess.Mensagem("PRODUTO ADICIONADO COM SUCESSO!");
            messageBoxSucess.ShowDialog();
        }
    }
}
