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
    public partial class TelaPerfil : Form
    {
        private TelaHome telaHome;

        public TelaPerfil(TelaHome home)
        {
            InitializeComponent();
            this.telaHome = home;
            this.DoubleBuffered = true;//parar de travar a tela
        }

        private void TelaPerfil_Load(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            //pergunta se deseja efetuar o pagamento ou nao
            TelaMessageBox messageBox = new TelaMessageBox();
            messageBox.RetornaSimNao("DESEJA SALVAR AS ALTERAÇÕES?");
            messageBox.ShowDialog();

            if (messageBox.btnSimClick == true)
            {
                TelaMessageBoxSucess telaMessageBoxSucess = new TelaMessageBoxSucess();
                telaMessageBoxSucess.Mensagem("ALTERAÇÕES SALVAS!");
                telaMessageBoxSucess.ShowDialog();
            }
            else if (messageBox.btnNaoClick == true)
            {
                this.Close();
                TelaPerfil telaPerfil = new TelaPerfil(this.telaHome);
                this.telaHome.PrintarTelaForaDaHome(telaPerfil);
            }
            else
            {
                messageBox.Mensagem("Selecione SIM ou NAO");
            }
        }

        private void btnAlterarSenha_Click(object sender, EventArgs e)
        {
            TelaAlterarSenha alterarSenha = new TelaAlterarSenha();
            alterarSenha.ShowDialog();
        }
    }
}
