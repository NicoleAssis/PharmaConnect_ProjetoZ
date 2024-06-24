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

namespace TESTE_GUNA.projeto.view
{
    public partial class FrmCompras : Form
    {
        public FrmCompras()
        {
            InitializeComponent();
        }

        private void btnX_Click(object sender, EventArgs e)
        {
            //fechar o programa
            Environment.Exit(0);
        }

        #region buttonsDoMenu

        private void btnHome_Click(object sender, EventArgs e)
        {
            FrmMenu telaMenu = new FrmMenu();
            this.Close();
            telaMenu.Show();
        }

        private void btnDepartamentos_Click(object sender, EventArgs e)
        {
            FrmDepartamentos telaDepartamentos = new FrmDepartamentos();
            this.Close();
            telaDepartamentos.Show();
        }

        private void btnPerfil_Click(object sender, EventArgs e)
        {
            FrmPerfil telaPerfil = new FrmPerfil();
            this.Close();
            telaPerfil.Show();
        }

        #endregion


        public void DeletarProduto(UserControlComprasProdutos produto)
        {
            //scrollCompras.Controls.Remove(produto);
           // scrollCompras.Refresh();
        }


        private void lblCalcularFrete_Click(object sender, EventArgs e)
        {
            FrmFrete telaFrete = new FrmFrete();
            telaFrete.ShowDialog();
        }

        private void btnPagamento_Click(object sender, EventArgs e)
        {
            FrmPagamento telaPag = new FrmPagamento();
            telaPag.ShowDialog();
        }

        private void btnComprasFinalizadas_Click(object sender, EventArgs e)
        {
            FrmComprasConcluidas telaComprasConcluidas = new FrmComprasConcluidas();
            telaComprasConcluidas.ShowDialog(); 
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void FrmCompras_Load(object sender, EventArgs e)
        {
            //ConfigureDataGridView();
            CarregarProdutos();
            
        }

        private void CarregarProdutos()
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
                ConfigureDataGridView();
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
            lblTotal.Text ="Rs: "+ totalGeral.ToString();
        }

        private void btnLimparCarrinho_Click(object sender, EventArgs e)
        {
            // Chamar o método para limpar o carrinho
            ComprasDAO comprasDAO = new ComprasDAO();
            comprasDAO.LimparCarrinho();

            // Atualizar o DataGridView ou realizar outras ações necessárias após limpar o carrinho
            // Exemplo: Recarregar os dados no DataGridView
            CarregarProdutos();
        }
    }
    /*
        private void btnSair_Click(object sender, EventArgs e)
        {
            //volta para a tela e login
            FrmLogin telaLogin = new FrmLogin();
            this.Close();
            telaLogin.Show();
        }

        private void scrollCompras_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel18_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnCompras_Click(object sender, EventArgs e)
        {

        }

        private void dataGridCarrinho_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }*/
    }

