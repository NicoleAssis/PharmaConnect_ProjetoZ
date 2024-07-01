using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TESTE_GUNA.projeto.dao;
using TESTE_GUNA.projeto.model;

namespace TESTE_GUNA.projeto.view
{
    public partial class FrmDepartamentoEscolhido : Form
    {
        int j = 1;
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

        
        //private void populateItems()
        //{
        //    //populate it here

        //    UserControlProduto[] usercontrolproduto = new UserControlProduto[20];


        //    for (int i = 0; i < usercontrolproduto.Length; i++)
        //    {
                
        //        usercontrolproduto[i] = new UserControlProduto();
        //        FrmDepartamentoEscolhido tela = new FrmDepartamentoEscolhido();
        //        ProdutoDAO dao = new ProdutoDAO();
        //        Produto obj = new Produto();
                

        //            dao.GetDetails(j);
        //            usercontrolproduto[i].NomeProduto = dao.nome_reader;
        //            usercontrolproduto[i].Dep = dao.dep_reader;
        //            usercontrolproduto[i].Preco = dao.preco_reader;
        //            usercontrolproduto[i].Desc = dao.desc_reader;
                    
                   

                


        //        if (flowLayoutPanel1.Controls.Count < 0)
        //        {

        //            flowLayoutPanel1.Controls.Clear();
        //        }
        //        else
        //        {
        //            flowLayoutPanel1.Controls.Add(usercontrolproduto[i]);
        //            j++;
        //        }



        //    }

        //}














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

        private void getDetail()
        {
        }
        private void FrmDepartamentoEscolhido_Load(object sender, EventArgs e)
        {
            //populateItems();
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

        private void userControlProduto2_Load(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void userControlProduto6_Load(object sender, EventArgs e)
        {

        }

        private void userControlProduto1_Load_1(object sender, EventArgs e)
        {

        }

        private void userControlProduto1_Load_2(object sender, EventArgs e)
        {

        }
    }
}
