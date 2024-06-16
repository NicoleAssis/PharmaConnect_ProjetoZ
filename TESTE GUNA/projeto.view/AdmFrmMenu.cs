﻿using System;
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
    public partial class AdmFrmMenu : Form
    {
        public AdmFrmMenu()
        {
            InitializeComponent();
        }

        private void btnX_Click(object sender, EventArgs e)
        {
            //button fechar o programa (X)
            Environment.Exit(0);
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

        private void txtPesquisa_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPesquisa_Click(object sender, EventArgs e)
        {
            txtPesquisa.Text = "";
        }

        private void btnCadastrarAdm_Click(object sender, EventArgs e)
        {
            AdmFrmCadastroAdministrador telaCadastro = new AdmFrmCadastroAdministrador();
            this.Close();
            telaCadastro.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }
    }
}
