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
    public partial class FrmFrete : Form
    {
        public FrmFrete()
        {
            InitializeComponent();
        }

        private void btnX_Click(object sender, EventArgs e)
        {
            //button fechar a tela de frete
            this.Close();
        }

        private void txtEstado_Click(object sender, EventArgs e)
        {
            txtEstado.Text = " ";
        }

        private void txtCidade_Click(object sender, EventArgs e)
        {
            txtCidade.Text = " ";
        }

        private void txtEndereco_Click(object sender, EventArgs e)
        {
            txtEndereco.Text = " ";
        }

        private void txtComplemento_Click(object sender, EventArgs e)
        {
            txtComplemento.Text = " ";
        }

        private void txtBairro_Click(object sender, EventArgs e)
        {
            txtBairro.Text = " ";
        }

        private void txtNum_Click(object sender, EventArgs e)
        {
            txtNum.Text = " ";
        }
    }
}
