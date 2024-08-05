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
    public partial class TelaDepartamentoEscolhido : Form
    {
        private TelaHome telaHome;
        private string Departamento;

        public TelaDepartamentoEscolhido(TelaHome home, string Departamento)
        {
            InitializeComponent();
            this.telaHome = home;
            this.DoubleBuffered = true;//parar de travar a tela
            this.Departamento = Departamento;
        }

        private void TelaDepartamentoEscolhido_Load(object sender, EventArgs e)
        {
            txtDepartamento.Text = Departamento.ToString();

            flowLayoutPanel1.Controls.Clear();

            UserControlProduto res = new UserControlProduto();
            res.searchResultDEP(TelaDepartamentos.departamento);

            loadDetails();
        }
        private void loadDetails()
        {
            foreach (ProdutoDAO p in ProdutoDAO.list)
            {
                UserControlProduto res = new UserControlProduto();
                res.DetailsB(p);
                flowLayoutPanel1.Controls.Add(res);
            }
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
