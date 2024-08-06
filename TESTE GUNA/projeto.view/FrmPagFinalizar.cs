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
            TelaMessageBox TelaMessageBox = new TelaMessageBox();
            TelaMessageBox.RetornaSimNao("DESEJA EFETUAR O PAGAMENTO?");
            TelaMessageBox.ShowDialog();

            if(TelaMessageBox.btnSimClick == true)
            {

                FormaPagamento obj = new FormaPagamento();

                PagamentoDAO dao = new PagamentoDAO();
                int idCliente = dao.RetornaIdCliente();

                obj.tipoPagamento = TipoDePagamento;
                obj.numCartao = NumeroCartão;
                obj.mes = Mes;
                obj.ano = Ano;
                obj.cvv = CVV;
                obj.idCliente = idCliente;



                // 2 passo criar obj da classe clienteDAO e chamar o metodo cadastrarCliente
                dao.CadastrarCompra(obj);




                //se confirmou que deseja efetuar o pagamento
                //TelaConfirmandoPagamento loadingPagamento = new TelaConfirmandoPagamento();
               // loadingPagamento.BringToFront();
               // loadingPagamento.ShowDialog();
                this.Hide();
            }
            else if(TelaMessageBox.btnNaoClick == true)
            {
                //se nao quer efetuar o pagamento
                this.Close();
                FrmCompras telaCompras = new FrmCompras();
                telaCompras.ShowDialog();
            }
            else
            {
                TelaMessageBox.Mensagem("Selecione SIM ou NAO");
            }

            



        }
    }
}
