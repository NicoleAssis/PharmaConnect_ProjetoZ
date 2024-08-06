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
using TESTE_GUNA.projet.conexao;
using TESTE_GUNA.projeto.model;
using TESTE_GUNA.projeto.dao;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;
using static Org.BouncyCastle.Crypto.Engines.SM2Engine;
using System.Windows.Media;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

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
            txtNomeProduto.Text = "";
        }

        private void txtPreco_Click(object sender, EventArgs e)
        {
            
        }

        private void txtQuantidade_Click(object sender, EventArgs e)
        {
            
        }





        private void btnCriarProduto_Click(object sender, EventArgs e)
        {
            ProdutoDAO dao = new ProdutoDAO();
            Validador validade = new Validador();
            var precoentrada = Convert.ToDecimal(txtPreco.Text);
            txtPreco.Text = precoentrada.ToString("N2"); 
            
            string nome = txtNomeProduto.Text;
            string desc = TxtDesc.Text;
            int quantidadeEstoque = int.Parse(txtQuantidade.Text);
            decimal precoUnitProduto = decimal.Parse(txtPreco.Text);
            string dep = validade.RemoveAccents(cbDepartamentos.Text);




            Produto obj = new Produto()
            {
                nomeProduto = nome,
                descProduto = desc,
                precoProduto = precoUnitProduto,
                qtdEstoque = quantidadeEstoque,
                departamento = dep
            };


            
            dao.CadastrarProduto(obj);



        }

        private void txtPreco_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Se a tecla digitada não for número e nem backspace
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 08 && e.KeyChar !=44)
            {
                //Atribui True no Handled para cancelar o evento
                e.Handled = true;
            }
        }

        private void txtQuantidade_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Se a tecla digitada não for número e nem backspace
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 08 )
            {
                //Atribui True no Handled para cancelar o evento
                e.Handled = true;
            }
            if(e.KeyChar == 44)
            {
                TelaMessageBox message = new TelaMessageBox();
                message.Mensagem("Por gentileza insira apenas números inteiros");
                message.ShowDialog();
            }
        }
    }
}
