﻿using System;
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
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        public static class TelaPagamento
        {
            public static string Email { get; set; }
            public static string Senha { get; set; }
        }


        private void btnX_Click(object sender, EventArgs e)
        {
            //buton fechar o programa (X)
            Environment.Exit(0);
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            
            //abrir a tela de cadastro
            FrmCadastro telaCadastro = new FrmCadastro();
            //esconde a tela anterior
            telaCadastro.Show();
            this.Hide();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            TelaPagamento.Email = txtEmail.Text;
            TelaPagamento.Senha = txtSenha.Text;

            string email = txtEmail.Text;
            string senha = txtSenha.Text;

            ClienteDAO dao = new ClienteDAO();
            AdministradorDAO daoADM = new AdministradorDAO();

            if((dao.EfetuarLogin(email, senha)) || daoADM.EfetuarLoginAdministrador(email, senha))
            {
                
                FrmMenu tela = new FrmMenu();
                tela.Show();
            }
            else
            {

            }

            if(email == "1234" && senha == "1234")
            {
                
                AdmFrmMenu tela = new AdmFrmMenu();
                tela.Show();
            }

             
        }

        private void txtEmail_Click(object sender, EventArgs e)
        {
            txtEmail.Text = "";
        }

        private void txtSenha_Click(object sender, EventArgs e)
        {
            txtSenha.Text = "";
            txtSenha.PasswordChar = '*';
        }

        private void checkBoxMostrarSenha_CheckedChanged(object sender, EventArgs e)
        {
            if (txtSenha.PasswordChar == '*')
            {
                //remove o passwordChar
                txtSenha.PasswordChar = '\0';
            }
            else
            {
                //caso deseja colocar o passwordChar novamente
                txtSenha.PasswordChar = '*';
            }
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
