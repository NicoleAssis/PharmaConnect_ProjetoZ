using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TESTE_GUNA.projeto.view
{
    public partial class FrmFrete : Form
    {
        public FrmFrete()
        {
            InitializeComponent();
        }

        private void btnX_Click(object sender, EventArgs e)
        {
            //button fechar a tela de frete
            this.Close();
        }

        private void txtEstado_Click(object sender, EventArgs e)
        {
            txtEstado.Text = " ";
        }

        private void txtCidade_Click(object sender, EventArgs e)
        {
            txtCidade.Text = " ";
        }

        private void txtEndereco_Click(object sender, EventArgs e)
        {
            txtEndereco.Text = " ";
        }

        private void txtComplemento_Click(object sender, EventArgs e)
        {
            txtComplemento.Text = " ";
        }

        private void txtBairro_Click(object sender, EventArgs e)
        {
            txtBairro.Text = " ";
        }

        private void txtNum_Click(object sender, EventArgs e)
        {
            txtNum.Text = " ";
        }

        private void btnpesquisacep_Click(object sender, EventArgs e)
        {
            //Botao consultar cep
            try
            {
                string cep = txtCep.Text;
                string xml = "https://viacep.com.br/ws/" + cep + "/xml/";
                
                DataSet dados = new DataSet();

                dados.ReadXml(xml);

                txtEndereco.Text = dados.Tables[0].Rows[0]["logradouro"].ToString();

                txtBairro.Text = dados.Tables[0].Rows[0]["bairro"].ToString();
                txtCidade.Text = dados.Tables[0].Rows[0]["localidade"].ToString();
                txtComplemento.Text = dados.Tables[0].Rows[0]["complemento"].ToString();
                txtEstado.Text = dados.Tables[0].Rows[0]["uf"].ToString();
            }
            catch (Exception)
            {

                MessageBox.Show("erro");
            }
        }
    }
}
