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
    public partial class AdmTelaCategoria : Form
    {
        private AdmTelaHome admHome;

        public AdmTelaCategoria(AdmTelaHome home)
        {
            InitializeComponent();
            this.admHome = home;
            this.DoubleBuffered = true;//parar de travar a tela
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            ProdutoDAO dao = new ProdutoDAO();

            //DataGridViewVendas.DataSource = dao.Teste();
        }
    }
}
