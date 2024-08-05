using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TESTE_GUNA.projeto.dao;
using TESTE_GUNA.projeto.model;
using TESTE_GUNA.projeto.view;

namespace TESTE_GUNA.projeto.window
{
    public partial class TelaFinalizarPagamento : Form
    {
        //printar a proxima tela
        private TelaCompras _telaCompras;
        private TelaHome telaHome;
        private string ano, cvv, mes, nomeCartao, numeroCartao;

        public TelaFinalizarPagamento(TelaCompras telaCompras, TelaHome home,string ano1, string cvv1, string mes1,string nomeCartao1,string numeroCartao1)
        {
            InitializeComponent();
            this.DoubleBuffered = true; // parar de travar a tela
            _telaCompras = telaCompras;
            telaHome = home;
            ano = ano1;
            cvv = cvv1;
            mes = mes1; 
            nomeCartao = nomeCartao1;
            numeroCartao = numeroCartao1;

        }


        private void TelaFinalizarPagamento_Load(object sender, EventArgs e)
        {
            lblTotal.Text = TelaCompras.totalCarrinho;
        }

        private void btnContinuar_Click(object sender, EventArgs e)
        {
            //pergunta se deseja efetuar o pagamento ou nao
            TelaMessageBox messageBox = new TelaMessageBox();
            messageBox.RetornaSimNao("DESEJA EFETUAR O PAGAMENTO?");
            messageBox.ShowDialog();

            int qtd_estoque, qtdComprada, estoqueAtualizado;

            if (messageBox.btnSimClick == true)
            {
                this.telaHome.Hide();
                TelaConfirmandoPagamento telaConfirmando = new TelaConfirmandoPagamento(this.telaHome);
                telaConfirmando.ShowDialog();
                this.telaHome.Show();

                decimal vt= CarrinhoDAO.totalCarrinhoEstatico;

                int recebimento = TelaPagamento.FormaPagamento;

                if (recebimento == 1)
                {
                    VendaDAO dao = new VendaDAO
                    {
                        total_venda = vt
                    };
                    dao.CadastroPagamentoPix(dao);
                    ProdutoDAO produto = new ProdutoDAO();

                    foreach (CarrinhoDAO p in CarrinhoDAO.list)
                    {
                        ItemVendaDAO res = new ItemVendaDAO();
                        res.venda_id = dao.RetornaIdUltimaVenda();
                        res.produto_id = p.id_produtoCarrinho;
                        res.quantidade = p.qtd_Carrinho;
                        res.subtotal = p.subtotalCarrinho;


                        res.CadastrarItem(res);

                      

                        qtd_estoque = produto.RetornaEstoqueAtual(p.id_produtoCarrinho);
                        qtdComprada = p.qtd_Carrinho;
                        estoqueAtualizado = qtd_estoque - qtdComprada;

                        produto.BaixaEstoque(p.id_produtoCarrinho, estoqueAtualizado);
                        p.Limpar();

                    }

                }else if(recebimento == 2)
                {
                    VendaDAO dao = new VendaDAO
                    {
                        total_venda = vt,
                        num_cartao = numeroCartao,
                        mes = mes,
                        ano = ano,
                        cvv = cvv

                    };
                    dao.CadastroPagamentoDebito(dao);
                    ProdutoDAO produto = new ProdutoDAO();

                    foreach (CarrinhoDAO p in CarrinhoDAO.list)
                    {
                        ItemVendaDAO res = new ItemVendaDAO();
                        res.venda_id = dao.RetornaIdUltimaVenda();
                        res.produto_id = p.id_produtoCarrinho;
                        res.quantidade = p.qtd_Carrinho;
                        res.subtotal = p.subtotalCarrinho;
                        

                        res.CadastrarItem(res);

                        

                        qtd_estoque = produto.RetornaEstoqueAtual(p.id_produtoCarrinho);
                        qtdComprada = p.qtd_Carrinho;
                        estoqueAtualizado = qtd_estoque - qtdComprada;

                        produto.BaixaEstoque(p.id_produtoCarrinho, estoqueAtualizado);
                        p.Limpar();
                    }
                }
                else if (recebimento == 3)
                {
                    VendaDAO dao = new VendaDAO
                    {
                        total_venda = vt,
                        num_cartao = numeroCartao,
                        mes = mes,
                        ano = ano,
                        cvv = cvv

                    };
                    dao.CadastroPagamentoCredito(dao);
                    ProdutoDAO produto = new ProdutoDAO();

                    foreach (CarrinhoDAO p in CarrinhoDAO.list)
                    {
                        ItemVendaDAO res = new ItemVendaDAO();
                        res.venda_id = dao.RetornaIdUltimaVenda();
                        res.produto_id = p.id_produtoCarrinho;
                        res.quantidade = p.qtd_Carrinho;
                        res.subtotal = p.subtotalCarrinho;


                        res.CadastrarItem(res);



                        qtd_estoque = produto.RetornaEstoqueAtual(p.id_produtoCarrinho);
                        qtdComprada = p.qtd_Carrinho;
                        estoqueAtualizado = qtd_estoque - qtdComprada;

                        produto.BaixaEstoque(p.id_produtoCarrinho, estoqueAtualizado);
                        p.Limpar();
                    }
                }




            }
            else if (messageBox.btnNaoClick == true)
            {
                this.Close();
                TelaCompras telaCompras = new TelaCompras(this.telaHome);
                this.telaHome.PrintarTelaForaDaHome(telaCompras);
            }
            else
            {
                messageBox.Mensagem("Selecione SIM ou NAO");
            }
           
        }
    }
}
