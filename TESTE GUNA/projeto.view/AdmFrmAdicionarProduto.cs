using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;
using Guna.UI2.WinForms;
using TESTE_GUNA.projeto.dao;
using TESTE_GUNA.projeto.model;

namespace TESTE_GUNA.projeto.view
{
    public partial class AdmFrmAdicionarProduto : Form
    {
        public AdmFrmAdicionarProduto()
        {
            InitializeComponent();
        }

        private void btnX_Click(object sender, EventArgs e)
        {
            //button fechar o programa (X)
            this.Close();
        }

        private void txtNomeCartao_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNomeCartao_Click(object sender, EventArgs e)
        {
            
        }

        private void txtPreco_Click(object sender, EventArgs e)
        {
            
        }

        private void txtQuantidade_Click(object sender, EventArgs e)
        {
            
        }

        private void btnCriarProduto_Click(object sender, EventArgs e)
        {

            var precoentrada = Convert.ToDecimal(txtPreco.Text);
            txtPreco.Text = precoentrada.ToString("N2"); 
            
            string nome = txtNomeProduto.Text;
            string desc = txtDescricao.Text;
            int quantidadeEstoque = int.Parse(txtQuantidade.Text);
            decimal precoUnitProduto = decimal.Parse(txtPreco.Text);
            string dep = cbDepartamentos.Text;
            FrmMessageBox mensagem = new FrmMessageBox();
            

            mensagem.Mensagem("PRODUTO CRIADO COM SUCESSO!");
            mensagem.ShowDialog();
            this.Close();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void TxtKeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {

            }


        }

        private void AdmFrmAdicionarProduto_Load(object sender, EventArgs e)
        {

        }

        private void txtDescricao_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtQuantidade_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtQuantidade_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Back)
            {
                return;
            }
            if (char.IsDigit(e.KeyChar) == false)
            {
                e.Handled = true;
                return;
            }
        }

        public static void Moeda(ref TextBox txt)
        {
            string n = string.Empty;
            double v = 0;

            try
            {
                n = txt.Text.Replace(",", "").Replace(".", "");
                if (n.Equals(""))
                {
                    n = "";
                    n.PadLeft(3, '0');
                }

                if (n.Length > 3 & n.Substring(0, 1) == "0")
                {
                    n = n.Substring(1, n.Length - 1);
                    v = Convert.ToDouble(n) / 100;
                    txt.Text = string.Format("{0:N}", v);
                    txt.SelectionStart = txt.Text.Length;
                }

            }
            catch (Exception)
            {

                throw;
            }
        }
        private void txtPreco_TextChanged(object sender, EventArgs e)
        {

            Moeda(ref txtPreco);
            
        }

        private void Moeda(ref Guna2TextBox txtPreco)
        {
            throw new NotImplementedException();
        }
    }
}
