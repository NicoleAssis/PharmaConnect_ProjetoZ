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

namespace TESTE_GUNA.projeto.window
{
    public partial class AdmTelaEditarProduto : Form
    {
        private AdmTelaHome admHome;
        public AdmTelaEditarProduto(int id, string nome, string descricao, decimal preco, int quantidade, string departamento, AdmTelaHome adm)
        {
            InitializeComponent();
            admHome = adm;
            txtNome.Text = nome;
            txtDescricao.Text = descricao;
            txtPreco.Text = preco.ToString();
            txtQtd.Text = quantidade.ToString();
            txtDep.Text= departamento;
        }

        private void btnX_Click(object sender, EventArgs e)
        {
            this.Close();

            AdmTelaProdutos telaProdutos = new AdmTelaProdutos(this.admHome);
            this.admHome.panelPharmaConnect.Visible = false;
            this.admHome.PrintarTelaForaDaHome(telaProdutos);
        }

        private void txtMensagem_Click(object sender, EventArgs e)
        {

        }

        private void btnAlterarSenha_Click(object sender, EventArgs e)
        {
            int id = AdmTelaProdutos.idProduto;
            ProdutoDAO dao = new ProdutoDAO();
            Produto obj = new Produto()
            {
                Id_Produto = id,
                nomeProduto = txtNome.Text,
                descProduto = txtDescricao.Text,
                precoProduto = Convert.ToDecimal(txtPreco.Text),
                qtdEstoque = Convert.ToInt32(txtQtd.Text),
                departamento =  txtDep.Text,


             };
            try
            {
                dao.updateProduct(obj);
            }
            catch (Exception)
            {
                TelaMessageBox mensagem = new TelaMessageBox();
                mensagem.Mensagem("Erro ao Cadastrar!");
                mensagem.ShowDialog();
            }

            this.Close();

            AdmTelaProdutos telaProdutos = new AdmTelaProdutos(this.admHome);
            this.admHome.panelPharmaConnect.Visible = false;
            this.admHome.PrintarTelaForaDaHome(telaProdutos);
        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void boxCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
