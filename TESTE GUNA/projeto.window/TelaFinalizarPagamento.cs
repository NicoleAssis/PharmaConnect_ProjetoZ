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
    }
}
