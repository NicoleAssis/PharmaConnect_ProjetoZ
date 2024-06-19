using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TESTE_GUNA.projeto.model;

namespace TESTE_GUNA.projeto.view
{
    public partial class AdmFrmCadastroAdministradorC2 : Form
    {
        private Administrador admin;

        // Construtor que aceita um argumento do tipo Administrador
        public AdmFrmCadastroAdministradorC2(Administrador admin)
        {
            InitializeComponent();
            this.admin = admin;
        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {
             
        }

        private void txtbase1_Click(object sender, EventArgs e)
        {
            //aparece o masked box em cima desse text box p coletar os dados do CPF corretamente
            txtCEP.Visible = true;
            txtbase1.Enabled = false;
        }

        private void btnX_Click(object sender, EventArgs e)
        {
            //button fechar o programa (X)
            this.Close();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {

        }
    }
}
