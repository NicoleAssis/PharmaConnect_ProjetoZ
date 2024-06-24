using MySql.Data.MySqlClient;
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
    public partial class FrmDepartamentoEscolhido : Form
    {
        public FrmDepartamentoEscolhido()
        {
            InitializeComponent();
        }

        public string Departamento {  get; set; }

        public FrmDepartamentoEscolhido(string departamento)
        {
            InitializeComponent();
            Departamento = departamento;
        }

        private void btnX_Click(object sender, EventArgs e)
        {
            // Cria uma nova instância de FrmDepartamentos
            FrmDepartamentos novaTelaDep = new FrmDepartamentos();
        

            // Itera sobre todas as janelas abertas e fecha as do tipo FrmDepartamentos
            foreach (Form telaAberta in Application.OpenForms.Cast<Form>().ToList())
            {
                if (telaAberta is FrmDepartamentos)
                {
                    telaAberta.Close();
                }
            }

            novaTelaDep.Show();
        }

        public void NomeDepartamento(string departamento)
        {
            lblDepartamento.Text = departamento;
        }


  
        private void FrmDepartamentoEscolhido_Load(object sender, EventArgs e)
        {
            CarregarDados();
        }

        private void CarregarDados()
        {
            DepartamentoDAO DAO = new DepartamentoDAO();
            DataTable produtos = DAO.ListarProdutosPorDepartamento(Departamento);

            if (produtos != null)
            {
                dataGridDep.DataSource = produtos; // Associar o DataTable ao DataGridView
            }
            else
            {
                MessageBox.Show("Não foi possível carregar os produtos para o departamento selecionado.");
            }
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblDepartamento_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void userControlProduto2_Load(object sender, EventArgs e)
        {

        }

        private void panelDep_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridDep_CellClick(object sender, DataGridViewCellEventArgs e)
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
                    int idProduto = Convert.ToInt32(dataGridDep.Rows[e.RowIndex].Cells["ID Produto"].Value);
                    string nomeProduto = dataGridDep.Rows[e.RowIndex].Cells["Nome Produto"].Value.ToString();
                    string descProduto = dataGridDep.Rows[e.RowIndex].Cells["Descrição"].Value.ToString();
                    decimal precoProduto = Convert.ToDecimal(dataGridDep.Rows[e.RowIndex].Cells["Preço"].Value);
                    int qtdEstoque = Convert.ToInt32(dataGridDep.Rows[e.RowIndex].Cells["Qtd Estoque"].Value);
                    string departamento = dataGridDep.Rows[e.RowIndex].Cells["Departamento"].Value.ToString();

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
        }
    }
}
