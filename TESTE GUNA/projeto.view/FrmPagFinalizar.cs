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

            ConfigureDataGridView();
            CarregarProdutosFinalizar();

        }
        private void CarregarProdutosFinalizar()
        {
            try
            {
                // Criar uma instância de ComprasDAO
                ComprasDAO comprasDAO = new ComprasDAO();

                // Obter os dados dos produtos
                DataTable tabelaProdutos = comprasDAO.ListarProdutos();

                // Preencher o DataGridView com os dados
                dataGridCarrinho.DataSource = tabelaProdutos;

                CalcularTotal();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao carregar produtos: " + erro.Message);
            }
        }

        private void ConfigureDataGridView()
        {
            // Ajustar a fonte do cabeçalho
            dataGridCarrinho.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 16, FontStyle.Bold);

            // Ajustar a fonte das células
            dataGridCarrinho.DefaultCellStyle.Font = new Font("Segoe UI", 12, FontStyle.Regular);

        }


        private void CalcularTotal()
        {
            decimal totalGeral = 0;

            // Percorrer as linhas do DataGridView e somar os valores da coluna 'Total'
            foreach (DataGridViewRow row in dataGridCarrinho.Rows)
            {
                if (row.Cells["Total"].Value != null)
                {
                    totalGeral += Convert.ToDecimal(row.Cells["Total"].Value);
                }
            }

            // Exibir o total geral em um Label ou TextBox
            lblTotal.Text = "Rs: " + totalGeral.ToString();
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
                FrmConfirmandoPagamento loadingPagamento = new FrmConfirmandoPagamento();
                loadingPagamento.BringToFront();
                loadingPagamento.ShowDialog();
                this.Hide();
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
