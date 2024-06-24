using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Guna.UI2.WinForms;
using TESTE_GUNA.projeto.dao;
using TESTE_GUNA.projeto.model;

namespace TESTE_GUNA.projeto.view
{
    public partial class FrmMenu : Form
    {
        public FrmMenu()
        {
            InitializeComponent();
        }

        private void guna2HtmlLabel1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }


        #region Buttons
        private void btnX_Click(object sender, EventArgs e)
        {
            //button fechar o programa (X)
            Environment.Exit(0);
        }


        private void btnDepartamentos_Click_1(object sender, EventArgs e)
        {
            //abrir a tela de cadastro
            FrmDepartamentos telaDepartamentos = new FrmDepartamentos();
            //esconde a tela anterior
            this.Close();
            //tela abre no centro
            //telaDepartamentos.StartPosition = FormStartPosition.CenterScreen;
            telaDepartamentos.Show();
        }

        private void btnCompras_Click(object sender, EventArgs e)
        {
            FrmCompras telaCompras = new FrmCompras();
            //esconde a tela anterior
            this.Close();
            telaCompras.Show();
        }

        private void btnPerfil_Click(object sender, EventArgs e)
        {
            FrmPerfil telaPerfil = new FrmPerfil();
            //esconde tela anterior
            this.Close();
            telaPerfil.Show();
        }
        private void btnComprasBarraPesquisa_Click(object sender, EventArgs e)
        {
            FrmCompras telaCompras = new FrmCompras();
            //esconde a tela anterior
            this.Close();
            telaCompras.Show();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            //mesma tela
        }
        private void btnPerfilBarraPerquisa_Click(object sender, EventArgs e)
        {
            FrmPerfil telaPerfil = new FrmPerfil();
            //esconde tela anterior
            this.Close();
            telaPerfil.Show();
        }

        #endregion

        private void FrmMenu_Load(object sender, EventArgs e)
        {
            CarregarProdutos();
            
        }

        private void CarregarProdutos()
        {
            try
            {
                // Criar uma instância de ComprasDAO
                ComprasDAO comprasDAO = new ComprasDAO();

                // Obter os dados dos produtos
                DataTable tabelaProdutos = comprasDAO.ListarProdutosMENU();

                // Preencher o DataGridView com os dados
                DataGridViewVendas.DataSource = tabelaProdutos;


            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao carregar produtos: " + erro.Message);
            }
        }



        private void scrollBar_Scroll(object sender, ScrollEventArgs e)
        {
            // scrollProdutos.AutoScrollPosition = new System.Drawing.Point(0, e.NewValue);
        }

        private void txtPesquisa_Click(object sender, EventArgs e)
        {
            txtPesquisa.Text = " ";
        }

        private void scrollProdutos_Paint(object sender, PaintEventArgs e)
        {


        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            //volta para a tela e login
            FrmLogin telaLogin = new FrmLogin();
            this.Close();
            telaLogin.Show();
        }

        private void txtPesquisa_TextChanged(object sender, EventArgs e)
        {
            string nome = "%" + txtPesquisa.Text + "%";
            ProdutoDAO dao = new ProdutoDAO();

            DataGridViewVendas.DataSource = dao.LIstarProdutosPorNome(nome);
        }
        private void ConfigureDataGridView()
        {
            // Definir a fonte padrão para todas as células
            FrmCompras c = new FrmCompras();
            c.dataGridCarrinho.DefaultCellStyle.Font = new Font("Arial", 12, FontStyle.Regular);

            // Definir a fonte para o cabeçalho das colunas
            c.dataGridCarrinho.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 14, FontStyle.Bold);

            // Outras configurações de estilo, se necessário
            c.dataGridCarrinho.AllowUserToAddRows = false; // Desabilitar a última linha em branco
        }



        private void DataGridViewVendas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //pergunta se deseja efetuar o pagamento ou nao
            FrmMessageBox frmMessageBox = new FrmMessageBox();
            frmMessageBox.RetornaSimNao("DESEJA ADICIONAR AO CARRINHO?");
            frmMessageBox.ShowDialog();

            if (frmMessageBox.btnSimClick == true)
            {

                if (e.RowIndex >= 0)
                {
                    // Obter o ID do produto da linha clicada
                    int idProduto = Convert.ToInt32(DataGridViewVendas.Rows[e.RowIndex].Cells["ID Produto"].Value);
                    string nomeProduto = DataGridViewVendas.Rows[e.RowIndex].Cells["Nome Produto"].Value.ToString();
                    string descProduto = DataGridViewVendas.Rows[e.RowIndex].Cells["Descrição"].Value.ToString();
                    decimal precoProduto = Convert.ToDecimal(DataGridViewVendas.Rows[e.RowIndex].Cells["Preço"].Value);
                    int qtdEstoque = Convert.ToInt32(DataGridViewVendas.Rows[e.RowIndex].Cells["Qtd Estoque"].Value);
                    string departamento = DataGridViewVendas.Rows[e.RowIndex].Cells["Departamento"].Value.ToString();

                    // Inserir o produto na tabela tb_carrinho
                    ComprasDAO DAO = new ComprasDAO();

                    DAO.InserirProdutoNoCarrinho(idProduto, nomeProduto, descProduto, precoProduto, qtdEstoque, departamento);
                }
            }
            else if (frmMessageBox.btnNaoClick == true)
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
            // Verificar se o clique foi em uma célula válida (não no cabeçalho)
           
        }

        private void DataGridViewVendas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }

}