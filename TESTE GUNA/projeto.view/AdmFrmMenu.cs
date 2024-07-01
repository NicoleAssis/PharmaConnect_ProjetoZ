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
            string nome = "%" + txtPesquisa.Text + "%";
            ProdutoDAO dao = new ProdutoDAO();

            DataGridViewVendas.DataSource = dao.LIstarProdutosPorNome(nome);
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

        private void DataGridViewVendas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnPerfil_Click(object sender, EventArgs e)
        {
            FrmADMPerfil telaPerfil = new FrmADMPerfil();
            this.Close();
            telaPerfil.Show();
        }

        private void btnVendas_Click(object sender, EventArgs e)
        {

        }

        private void AdmFrmMenu_Load(object sender, EventArgs e)
        {

        }

        private void CarregarProdutos()
        {
            try
            {
                // Criar uma instância de ComprasDAO
                ComprasDAO comprasDAO = new ComprasDAO();

                // Obter os dados dos produtos
                DataTable tabelaProdutos = comprasDAO.ListarProdutosVendasADM();

                // Preencher o DataGridView com os dados
                DataGridViewVendas.DataSource = tabelaProdutos;

                // ConfigureDataGridView();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao carregar produtos: " + erro.Message);
            }
        }

        private void DataGridViewVendas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ////Pegando os dados do produto selecionado
            //txtNomeProduto.Text = DataGridViewVendas.CurrentRow.Cells[1].Value.ToString();
            //txtDescricao.Text = DataGridViewVendas.CurrentRow.Cells[2].Value.ToString();
            //txtPreco.Text = DataGridViewVendas.CurrentRow.Cells[3].Value.ToString();
            //txtQuantidade.Text = DataGridViewVendas.CurrentRow.Cells[4].Value.ToString();
        }


        private void DataGridViewVendas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void userControlProduto1_Load(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void AdmFrmMenu_Load(object sender, EventArgs e)
        {
            
        }
    }
}
