using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
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

        private void txtbase1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCEP_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
           
        }

        private void txtCEP_Click(object sender, EventArgs e)
        {
            try
            {
                string cep = txtCEP.Text;

                // Validação simples do CEP (formato básico de 8 dígitos)
                if (cep.Length != 8 || !cep.All(char.IsDigit))
                {
                    MessageBox.Show("CEP inválido. Por favor, digite um CEP válido.");
                    return;
                }

                string xmlUrl = "https://viacep.com.br/ws/" + cep + "/xml/";

                DataSet dados = new DataSet();

                try
                {
                    dados.ReadXml(xmlUrl);

                    if (dados.Tables.Count == 0 || dados.Tables[0].Rows.Count == 0)
                    {
                        throw new Exception("Dados não encontrados no XML.");
                    }

                    txtEndereco.Text = dados.Tables[0].Rows[0]["logradouro"].ToString();
                    txtBairro.Text = dados.Tables[0].Rows[0]["bairro"].ToString();
                    txtCidade.Text = dados.Tables[0].Rows[0]["localidade"].ToString();
                    txtComplemento.Text = dados.Tables[0].Rows[0]["complemento"].ToString();
                    txtEstado.Text = dados.Tables[0].Rows[0]["uf"].ToString();
                }
                catch (WebException webEx)
                {
                    MessageBox.Show("Erro ao acessar a internet: " + webEx.Message);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Endereço não encontrado, por favor digite manualmente. Detalhes: " + ex.Message);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }

        }
    }
}
