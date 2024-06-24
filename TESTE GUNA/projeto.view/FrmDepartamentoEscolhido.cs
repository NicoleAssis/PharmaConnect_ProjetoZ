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
        public FrmDepartamentoEscolhido()
        {
            InitializeComponent();
        }

        
        private void populateItems()
        {
            //populate it here

            UserControlProduto[] usercontrolproduto = new UserControlProduto[20];


            for (int i = 0; i < usercontrolproduto.Length; i++)
            {
                
                usercontrolproduto[i] = new UserControlProduto();
                FrmDepartamentoEscolhido tela = new FrmDepartamentoEscolhido();
                ProdutoDAO dao = new ProdutoDAO();
                Produto obj = new Produto();
                

                    dao.GetDetails(i);
                    usercontrolproduto[i].NomeProduto = dao.nome_reader;
                    usercontrolproduto[i].Dep = dao.dep_reader;
                    usercontrolproduto[i].Preco = dao.preco_reader;
                    usercontrolproduto[i].Desc = dao.desc_reader;
                    Console.WriteLine(obj.descProduto);

                


                if (flowLayoutPanel1.Controls.Count < 0)
                {

                    flowLayoutPanel1.Controls.Clear();
                }
                else
                {
                    flowLayoutPanel1.Controls.Add(usercontrolproduto[i]);
                }



            }

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

        private void getDetail()
        {
        }
        private void FrmDepartamentoEscolhido_Load(object sender, EventArgs e)
        {
            populateItems();
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

        private void userControlProduto1_Load(object sender, EventArgs e)
        {

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
