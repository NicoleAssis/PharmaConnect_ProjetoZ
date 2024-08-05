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
            TelaDepartamentoEscolhido tela = new TelaDepartamentoEscolhido(this.telaHome, "ANALGÉSICOS");
            this.telaHome.PrintarTela(tela);
            tela.BringToFront();

        }

        private void btnParaDiabetes_Click(object sender, EventArgs e)
        {
            departamento = "Diabeticos";
            TelaDepartamentoEscolhido tela = new TelaDepartamentoEscolhido(this.telaHome, "PARA DIABETES");
            this.telaHome.PrintarTela(tela);
            tela.BringToFront();
        }

        private void btnAntiinflamatorios_Click(object sender, EventArgs e)
        {
            departamento = "Antinflamatorio";
            TelaDepartamentoEscolhido tela = new TelaDepartamentoEscolhido(this.telaHome, "ANTI-INFLAMATÓRIOS");
            this.telaHome.PrintarTela(tela);
            tela.BringToFront();
        }

        private void btnGinecologia_Click(object sender, EventArgs e)
        {
            departamento = "Ginecologicos";
            TelaDepartamentoEscolhido tela = new TelaDepartamentoEscolhido(this.telaHome, "GINECOLOGIA");
            this.telaHome.PrintarTela(tela);
            tela.BringToFront();
        }

        private void btnAntivirais_Click(object sender, EventArgs e)
        {
            departamento = "Antivirais e Antibioticos";
            TelaDepartamentoEscolhido tela = new TelaDepartamentoEscolhido(this.telaHome, "ANTIVIRAIS E ANTIBIÓTICOS");
            this.telaHome.PrintarTela(tela);
            tela.BringToFront();
        }

        private void btnHipertensao_Click(object sender, EventArgs e)
        {
            departamento = "Hipertensao";
            TelaDepartamentoEscolhido tela = new TelaDepartamentoEscolhido(this.telaHome, "HIPERTENSÃO");
            this.telaHome.PrintarTela(tela);
            tela.BringToFront();
        }

        private void btnDermatologicos_Click(object sender, EventArgs e)
        {
            departamento = "Dermatologicos";
            TelaDepartamentoEscolhido tela = new TelaDepartamentoEscolhido(this.telaHome, "DERMATOLÓGICOS");
            this.telaHome.PrintarTela(tela);
            tela.BringToFront();
        }

        private void btnSuplementos_Click(object sender, EventArgs e)
        {
            departamento = "Suplementos e Vitaminas";
            TelaDepartamentoEscolhido tela = new TelaDepartamentoEscolhido(this.telaHome, "SUPLEMENTOS E VITAMINAS");
            this.telaHome.PrintarTela(tela);
            tela.BringToFront();
        }
    }
}
