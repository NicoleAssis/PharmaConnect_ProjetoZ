using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TESTE_GUNA.projeto.window
{
    public partial class TelaDepartamentos : Form
    {
        private TelaHome telaHome;

        public TelaDepartamentos(TelaHome home)
        {
            InitializeComponent();
            this.telaHome = home;
            this.DoubleBuffered = true;//parar de travar a tela
        }

        public static string departamento;
        private void TelaDepartamentos_Load(object sender, EventArgs e)
        {
            
        }

        private void btnAnalgesicos_Click(object sender, EventArgs e)
        {
            departamento = "Analgesico";
        }

        private void btnParaDiabetes_Click(object sender, EventArgs e)
        {
            departamento = "Diabeticos";
        }

        private void btnAntiinflamatorios_Click(object sender, EventArgs e)
        {
            departamento = "Antinflamatorio";
        }

        private void btnGinecologia_Click(object sender, EventArgs e)
        {
            departamento = "Ginecologicos";
        }

        private void btnAntivirais_Click(object sender, EventArgs e)
        {
            departamento = "Antivirais e Antibioticos";
        }

        private void btnHipertensao_Click(object sender, EventArgs e)
        {
            departamento = "Hipertensao";
        }

        private void btnDermatologicos_Click(object sender, EventArgs e)
        {
            departamento = "Dermatologicos";
        }

        private void btnSuplementos_Click(object sender, EventArgs e)
        {
            departamento = "Sumplementos e Vitaminas";
        }
    }
}
