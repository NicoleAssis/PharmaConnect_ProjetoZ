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

namespace TESTE_GUNA.projeto.window
{
    public partial class AdmTelaVendas : Form
    {
        private AdmTelaHome admHome;

        public AdmTelaVendas(AdmTelaHome home)
        {
            InitializeComponent();
            this.admHome = home;
            this.DoubleBuffered = true;//parar de travar a tela
        }

        private void AdmTelaVendas_Load(object sender, EventArgs e)
        {
            ProdutoDAO dao = new ProdutoDAO();

            VendaDAO v = new VendaDAO();
            DataGridViewVendas.DataSource = v.ListarVendas();
        }

        private void txtPesquisa_TextChanged(object sender, EventArgs e)
        {

            VendaDAO dao = new VendaDAO();
            DataGridViewVendas.DataSource = dao.PerformSearch(txtPesquisa.Text);
           

        }

        private void DataGridViewVendas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void DataGridViewVendas_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtPesquisa_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter) // Executa a busca ao pressionar Enter
            {
                VendaDAO dao = new VendaDAO();
                DataGridViewVendas.DataSource = dao.PerformSearch(txtPesquisa.Text);
                e.Handled = true; // Impede o som do "ding" ao pressionar Enter
            }
        }
    }
}
