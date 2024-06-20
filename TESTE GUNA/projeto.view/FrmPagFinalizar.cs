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
    public partial class FrmPagFinalizar : Form
    {
        public FrmPagFinalizar()
        {
            InitializeComponent();
        }

        public string TipoDePagamento { get; set; }
        public string NumeroCartão { get; set; }
        public string NomeCartao { get; set; }
        public string Mes { get; set; }
        public string Ano { get; set; }
        public string CVV { get; set; }


        public FrmPagFinalizar(string tipoPagamento, string numeroCartão, string nomeCartao, string mes, string ano, string cVV)
        {
            InitializeComponent();

            TipoDePagamento = tipoPagamento;
            NumeroCartão = numeroCartão;
            NomeCartao = nomeCartao;
            Mes = mes;
            Ano = ano;
            CVV = cVV;
        }


        private void FrmPagFinalizar_Load(object sender, EventArgs e)
        {
            FrmMessageBox frmMessageBox = new FrmMessageBox();
            //frmMessageBox.Mensagem(TipoDePagamento +" "+ NumeroCartão + " " + NomeCartao + " " + Mes + " " + Ano + " " + CVV);
            FrmLogin frmLogin = new FrmLogin();
            frmMessageBox.ShowDialog();

            //printa os produtos na tela de scroll
            for (int i = 0; i <= 4; i++)
            {
                UserControlPagItensEscolhidos userControlProdutos = new UserControlPagItensEscolhidos();
                userControlProdutos.PrintarProduto(1);
                scrollProdutosEscolhidos.Controls.Add(userControlProdutos);
            }


        }

        private void btnX_Click(object sender, EventArgs e)
        {
            //button fechar a tela
            this.Close();
        }

        private void btnSalvarAlteracoes_Click(object sender, EventArgs e)
        {
            //Button finalizar o pagamento
            
            //pergunta se deseja efetuar o pagamento ou nao
            FrmMessageBox frmMessageBox = new FrmMessageBox();
            frmMessageBox.RetornaSimNao("DESEJA EFETUAR O PAGAMENTO?");
            frmMessageBox.ShowDialog();

            if(frmMessageBox.btnSimClick == true)
            {







                //se confirmou que deseja efetuar o pagamento
                frmMessageBox.Mensagem("PAGAMENTO EFETUADO COM SUCESSO!");
                frmMessageBox.ShowDialog();
                this.Close();
            }
            else if(frmMessageBox.btnNaoClick == true)
            {
                //se nao quer efetuar o pagamento
                this.Close();
                FrmCompras telaCompras = new FrmCompras();
                telaCompras.ShowDialog();
            }
            else
            {
                frmMessageBox.Mensagem("Selecione SIM ou NAO");
            }

            



        }
    }
}
