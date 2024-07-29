using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

using TESTE_GUNA.projet.conexao;
using TESTE_GUNA.projeto.model;
using TESTE_GUNA.projeto.view;


using System.Diagnostics.Eventing.Reader;
using System.Windows.Forms;
using System.Globalization;
using System.Data;
using Guna.UI2.WinForms;
using System.Data.SqlClient;
using TESTE_GUNA.projeto.window;
namespace TESTE_GUNA.projeto.dao
{
     class CarrinhoDAO : CarrinhoB
    {

        //Conecta com o Banco de dados
        private MySqlConnection conexao;
      


        //Construtor
        public CarrinhoDAO()
        {
            this.conexao = new ConnectionFactory().getconnection();
        }


       

        public void CadastrarProdutoCarrinho(CarrinhoB obj)
        {
            try
            {

                //Definindo comando SQL
                string sql = @"insert into tb_carrinho (id_produtoCarrinho, nome_produtoCarrinho,desc_produtoCarrinho,preco_produtoCarrinho,qtd_Carrinho)
                            values(@id_produtoCarrinho,@nome_produtoCarrinho,@desc_produtoCarrinho,@preco_produtoCarrinho,@qtd_Carrinho)";


                //Organizando comando SQL
                MySqlCommand executacmd = new MySqlCommand(sql, conexao);

                int qtdInicial = 1;
                executacmd.Parameters.AddWithValue("@id_produtoCarrinho", obj.id_produtoCarrinho);
                executacmd.Parameters.AddWithValue("@nome_produtoCarrinho", obj.nome_produtoCarrinho);
                executacmd.Parameters.AddWithValue("@desc_produtoCarrinho", obj.desc_produtoCarrinho);
                executacmd.Parameters.AddWithValue("@preco_produtoCarrinho", obj.preco_produtoCarrinho);
                executacmd.Parameters.AddWithValue("qtd_Carrinho", qtdInicial);




                //Abrindo conexao e aplicando sql
                conexao.Open();
                executacmd.ExecuteNonQuery();

                //fechando conexao
                conexao.Close();

            }
            catch (Exception erro)
            {

                MessageBox.Show("Erro Identificado:" + erro);
            }
        }
      


    }
}
