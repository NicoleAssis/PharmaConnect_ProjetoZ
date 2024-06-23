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
        public static bool view = false;
        public static int publid_id;
        private void getDetail()
        {
            ProdutoDAO dao = new ProdutoDAO();
            dao.GetDetails(UserControlProduto.
        }
        private void FrmDepartamentoEscolhido_Load(object sender, EventArgs e)
        {

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
    }
}
