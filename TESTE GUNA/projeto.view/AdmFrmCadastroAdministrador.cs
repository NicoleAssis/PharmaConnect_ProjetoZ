using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;
using TESTE_GUNA.projeto.dao;
using TESTE_GUNA.projeto.model;

namespace TESTE_GUNA.projeto.view
{
    public partial class AdmFrmCadastroAdministrador : Form
    {
        public AdmFrmCadastroAdministrador()
        {
            InitializeComponent();
        }

        private void txtBase_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtBase2_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBoxMostrarSenha_CheckedChanged(object sender, EventArgs e)
        {
            if (txtSenha.PasswordChar == '*')
            {
                //remove o passwordChar
                txtSenha.PasswordChar = '\0';
            }
            else
            {
                //caso deseja colocar o passwordChar novamente
                txtSenha.PasswordChar = '*';
            }
        }

        private void btnX_Click(object sender, EventArgs e)
        {
            //button fechar o programa (X)
            this.Close();
        }

        private void txtBase3_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtBase_Click(object sender, EventArgs e)
        {
            //aparece o masked box em cima desse text box p coletar os dados do CPF corretamente
            txtCNPJ.Visible = true;
            txtBase.Enabled = false;
        }

        private void txtBase2_Click(object sender, EventArgs e)
        {
            //aparece o masked box em cima desse text box p coletar os dados do CPF corretamente
            txtTelefone.Visible = true;
            txtBase2.Enabled = false;
        }

        private void txtBase3_Click(object sender, EventArgs e)
        {
            //aparece o masked box em cima desse text box p coletar os dados do CPF corretamente
            txtCelular.Visible = true;
            txtBase3.Enabled = false;
        }

       
        //{
        //    int nivelacesso = 1;
        //    //1- passo - Receber os dados dentro do objeto modelo de adm
        //    string cnpj_string = txtCNPJ.Text.Replace(".", "").Replace("-", ""); ;
        //    Administrador obj= new Administrador();
        //    long cnpj_inteiro = long.Parse((cnpj_string));
        //    obj.nome = txtNome.Text;
        //    obj.cnpj = cnpj_inteiro;
        //    obj.email = txtEmail.Text;
        //    obj.telefone = (txtTelefone.Text);
        //    obj.celular = txtCelular.Text;
        //    obj.senha = txtSenha.Text;
        //    obj.nivel = nivelacesso;

        //    //2 passo- Criar um objeto da classe AdministradorDAO e chamar o metodo cadastrarADM
        //    AdministradorDAO dao = new AdministradorDAO();
        //    dao.CadastrarAdministrador1(obj);

        //     //Validação dos campos
        //    if (string.IsNullOrWhiteSpace(txtCNPJ.Text))
        //    {
        //       FrmMessageBox frmMessageBox = new FrmMessageBox();
        //        frmMessageBox.Mensagem("Por favor, preencha um CNPJ valido");
        //        frmMessageBox.ShowDialog();
        //        return;
        //    }
        //    if (string.IsNullOrWhiteSpace(txtNome.Text))
        //    {
        //        FrmMessageBox frmMessageBox = new FrmMessageBox();
        //        frmMessageBox.Mensagem("Por favor, preencha um Nome valido");
        //        frmMessageBox.ShowDialog();
        //        return;
        //    }
        //    if (string.IsNullOrWhiteSpace(txtEmail.Text))
        //    {
        //        FrmMessageBox frmMessageBox = new FrmMessageBox();
        //        frmMessageBox.Mensagem("Por favor, preencha um Email valido");
        //        frmMessageBox.ShowDialog();
        //        return;

        //    }

        //    if (string.IsNullOrWhiteSpace(txtTelefone.Text))
        //    {
        //        FrmMessageBox frmMessageBox = new FrmMessageBox();
        //        frmMessageBox.Mensagem("Por favor, preencha um Telefone valido");
        //        frmMessageBox.ShowDialog();
        //        return;
        //    }
        //    if (string.IsNullOrWhiteSpace(txtCelular.Text))
        //    {
        //        FrmMessageBox frmMessageBox = new FrmMessageBox();
        //        frmMessageBox.Mensagem("Por favor, preencha um Celular valido");
        //        frmMessageBox.ShowDialog();
        //        return;
        //    }
        //    if (string.IsNullOrWhiteSpace(txtSenha.Text))
        //    {
        //        FrmMessageBox frmMessageBox = new FrmMessageBox();
        //        frmMessageBox.Mensagem("Por favor, preencha uma Senha valida");
        //        frmMessageBox.ShowDialog();
        //        return;
        //    }
            
           
        //    //// Se todos os campos estiverem preenchidos corretamente, cria o objeto Administrador
        //    Administrador admin = new Administrador
        //    {
        //        cnpj = Convert.ToInt64(txtCNPJ.Text),
        //        nome = txtNome.Text,
        //        email = txtEmail.Text,
        //        celular = txtCelular.Text,
        //        senha = txtSenha.Text,
        //    };

        //     //Passa o objeto admin para a próxima tela (Form2)
        //    AdmFrmCadastroAdministradorC2 form2 = new AdmFrmCadastroAdministradorC2(admin);
        //    form2.Show(); // Certifique-se de estar chamando o método Show() na instância do formulário
        //    this.Hide();
        //}

        


        private void txtCNPJ_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            {
                int nivelacesso = 1;
                // Validação dos campos
                if (string.IsNullOrWhiteSpace(txtCNPJ.Text))
                {
                    FrmMessageBox frmMessageBox = new FrmMessageBox();
                    frmMessageBox.Mensagem("Por favor, preencha um CNPJ válido");
                    frmMessageBox.ShowDialog();
                    return;
                }
                if (string.IsNullOrWhiteSpace(txtNome.Text))
                {
                    FrmMessageBox frmMessageBox = new FrmMessageBox();
                    frmMessageBox.Mensagem("Por favor, preencha um Nome válido");
                    frmMessageBox.ShowDialog();
                    return;
                }
                if (string.IsNullOrWhiteSpace(txtEmail.Text))
                {
                    FrmMessageBox frmMessageBox = new FrmMessageBox();
                    frmMessageBox.Mensagem("Por favor, preencha um Email válido");
                    frmMessageBox.ShowDialog();
                    return;
                }
                if (string.IsNullOrWhiteSpace(txtTelefone.Text))
                {
                    FrmMessageBox frmMessageBox = new FrmMessageBox();
                    frmMessageBox.Mensagem("Por favor, preencha um Telefone válido");
                    frmMessageBox.ShowDialog();
                    return;
                }
                if (string.IsNullOrWhiteSpace(txtCelular.Text))
                {
                    FrmMessageBox frmMessageBox = new FrmMessageBox();
                    frmMessageBox.Mensagem("Por favor, preencha um Celular válido");
                    frmMessageBox.ShowDialog();
                    return;
                }
                if (string.IsNullOrWhiteSpace(txtSenha.Text))
                {
                    FrmMessageBox frmMessageBox = new FrmMessageBox();
                    frmMessageBox.Mensagem("Por favor, preencha uma Senha válida");
                    frmMessageBox.ShowDialog();
                    return;
                }

                // Se todos os campos estiverem preenchidos corretamente, cria o objeto Administrador
                string cnpj_string = txtCNPJ.Text.Replace(".", "").Replace("-", "");
                long cnpj_inteiro = long.Parse(cnpj_string);
                Administrador admin = new Administrador
                {
                    cnpj = cnpj_inteiro,
                    nome = txtNome.Text,
                    email = txtEmail.Text,
                    telefone = txtTelefone.Text,
                    celular = txtCelular.Text,
                    senha = txtSenha.Text,
                    nivel = nivelacesso
                };

                // Passa o objeto admin para a próxima tela (Form2)
                AdmFrmCadastroAdministradorC2 form2 = new AdmFrmCadastroAdministradorC2(admin);
                form2.Show(); // Certifique-se de estar chamando o método Show() na instância do formulário
                this.Hide();

            }

        }
    }
}

