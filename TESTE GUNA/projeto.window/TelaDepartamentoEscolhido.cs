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
    public partial class TelaDepartamentoEscolhido : Form
    {
        private TelaHome telaHome;

        public TelaDepartamentoEscolhido(TelaHome home)
        {
            InitializeComponent();
            this.telaHome = home;
            this.DoubleBuffered = true;//parar de travar a tela
        }

        private void TelaDepartamentoEscolhido_Load(object sender, EventArgs e)
        {

        }
    }
}
