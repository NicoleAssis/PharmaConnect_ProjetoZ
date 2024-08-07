using MySql.Data.MySqlClient;
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
using TESTE_GUNA.projeto.window;

namespace TESTE_GUNA.projeto.window
{
    public partial class TelaPerfil : Form
    {
        private TelaHome telaHome;
        public string nome;
        public string email;


        public TelaPerfil(TelaHome home)
        {
            InitializeComponent();
            this.telaHome = home;
            this.DoubleBuffered = true;//parar de travar a tela
        }

        private int idDoClienteLogado = 1;
        private void TelaPerfil_Load(object sender, EventArgs e)
        {
            ClienteDAO dao = new ClienteDAO();
            int idcliente = dao.RetornaIdCliente();

            dao.BuscarClientesPorId(idcliente, this);

           //txtEmail.Text = email.ToString();
           // txtNome.Text = nome.ToString();
        }


    

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            //pergunta se deseja efetuar o pagamento ou nao
            TelaMessageBox messageBox = new TelaMessageBox();
            messageBox.RetornaSimNao("DESEJA SALVAR AS ALTERAÇÕES?");
            messageBox.ShowDialog();

            if (messageBox.btnSimClick == true)
            {
                ClienteDAO dao = new ClienteDAO();
                int idcliente = dao.RetornaIdCliente();
                dao.AtualizarCliente(idcliente, txtNome.Text, txtEmail.Text);



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

        private void txtNome_TextChanged(object sender, EventArgs e)
        {
          
        }
    }
}
