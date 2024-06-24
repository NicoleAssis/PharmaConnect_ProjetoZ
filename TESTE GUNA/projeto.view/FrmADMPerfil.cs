using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TESTE_GUNA.projeto.dao;
using TESTE_GUNA.projeto.model;

namespace TESTE_GUNA.projeto.view
{
    public partial class FrmADMPerfil : Form
    {
        
        public FrmADMPerfil()
        {
            InitializeComponent();

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            //volta para a tela e login
            FrmLogin telaLogin = new FrmLogin();
            this.Close();
            telaLogin.Show();
        }

        private void btnProdutos_Click(object sender, EventArgs e)
        {
            AdmFrmProdutos telaProdutos = new AdmFrmProdutos();
            this.Close();
            telaProdutos.Show();
        }

        private void btnCadastrarAdm_Click(object sender, EventArgs e)
        {

            AdmFrmCadastroAdministrador telaCadastro = new AdmFrmCadastroAdministrador();
            this.Close();
            telaCadastro.Show();
        }

        private void btnVendas_Click(object sender, EventArgs e)
        {
            AdmFrmMenu telaMenu = new AdmFrmMenu();
            this.Close();
            telaMenu.ShowDialog();
        }
        private void btnPerfilAdm_Click(object sender, EventArgs e)
        {
           
        }

    }
}

