using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TESTE_GUNA.projet.conexao;
using TESTE_GUNA.projeto.view;

namespace TESTE_GUNA.projeto.dao
{
    public class ComprasDAO
    {

        //Conecta com o Banco de dados
        private MySqlConnection conexao;


        //Construtor
        public ComprasDAO()
        {
            this.conexao = new ConnectionFactory().getconnection();

        }


        #region


        public void LimparCarrinho()
        {
            try
            {
                // Montar o comando SQL para deletar todos os registros da tabela
                string sql = "DELETE FROM tb_carrinho;";

                // Preparar o comando SQL
                MySqlCommand cmd = new MySqlCommand(sql, conexao);

                // Abrir conexão e executar o comando
                conexao.Open();
                int linhasAfetadas = cmd.ExecuteNonQuery();
                conexao.Close();

                // Verificar se a exclusão foi bem-sucedida
                if (linhasAfetadas > 0)
                {
                    //MessageBox.Show("Carrinho limpo com sucesso!");
                }
                else
                {
                    //MessageBox.Show("Falha ao limpar o carrinho.");
                }
            }
            catch (Exception erro)
            {
                //MessageBox.Show("Erro ao limpar o carrinho: " + erro.Message);
            }
        }



        #endregion






        #region

        public void InserirProdutoNoCarrinho(int idProduto, string nomeProduto, string descProduto, decimal precoProduto, int qtdEstoque, string departamento)
        {
            try
            {
                // Montar o comando SQL de inserção
                string sql = @"
            INSERT INTO tb_carrinho (nome_produto, desc_produto, preco_produto, qtd_estoque, departamento)
            VALUES (@nome_produto, @desc_produto, @preco_produto, @qtd_estoque, @departamento);
        ";

                // Preparar o comando SQL
                MySqlCommand cmd = new MySqlCommand(sql, conexao);

                // Adicionar parâmetros
                cmd.Parameters.AddWithValue("@nome_produto", nomeProduto);
                cmd.Parameters.AddWithValue("@desc_produto", descProduto);
                cmd.Parameters.AddWithValue("@preco_produto", precoProduto);
                cmd.Parameters.AddWithValue("@qtd_estoque", 1);
                cmd.Parameters.AddWithValue("@departamento", departamento);

                // Abrir conexão e executar o comando
                conexao.Open();
                int linhasAfetadas = cmd.ExecuteNonQuery();
                conexao.Close();

                // Verificar se a inserção foi bem-sucedida
                if (linhasAfetadas > 0)
                {
                   // MessageBox.Show("Produto adicionado ao carrinho com sucesso!");
                }
                else
                {
                   // MessageBox.Show("Falha ao adicionar o produto ao carrinho.");
                }
            }
            catch (Exception erro)
            {
               // MessageBox.Show("Erro ao inserir produto no carrinho: " + erro.Message);
            }
        }




        #endregion






        #region 


        public DataTable ListarProdutosMENU()
        {
            try
            {
                //criar datatable e comando sql
                DataTable tabelaProdutos = new DataTable();



                string sql = @"
                                SELECT  
                                    id_produto AS 'ID Produto',
                                    nome_produto AS 'Nome Produto',
                                    desc_produto AS 'Descrição',
                                    preco_produto AS 'Preço',
                                    qtd_estoque AS 'Qtd Estoque',
                                    departamento AS 'Departamento'
                                FROM 
                                    tb_produto;
                            ";



                //organizar o comando e executar
                MySqlCommand executacmd = new MySqlCommand(sql, conexao);

                conexao.Open();
                executacmd.ExecuteNonQuery();

                //criar mysqldataapter para preencher os dados no data table
                MySqlDataAdapter da = new MySqlDataAdapter(executacmd);
                da.Fill(tabelaProdutos);

                conexao.Close();


                return tabelaProdutos;


            }
            catch (Exception erro)
            {
                //MessageBox.Show("Erro ao executar o comando sql: " + erro);
                FrmMessageBox mensagem = new FrmMessageBox();
                mensagem.Mensagem("erro dao compra" + erro);
                mensagem.ShowDialog();
                return null;
            }

        }





        #endregion




        #region listar

        public DataTable ListarProdutos()
        {
            try
            {
                //criar datatable e comando sql
                DataTable tabelaProdutos = new DataTable();



                string sql = @"
                                SELECT 
                                    tb_carrinho.nome_produto AS 'Produto',
                                    tb_carrinho.preco_produto AS 'Preço Unitário',
                                    tb_carrinho.qtd_estoque AS 'Quantidade',
                                    (tb_carrinho.preco_produto * tb_carrinho.qtd_estoque) AS 'Total'
                                FROM 
                                    tb_carrinho;";


                //organizar o comando e executar
                MySqlCommand executacmd = new MySqlCommand(sql, conexao);

                conexao.Open();
                executacmd.ExecuteNonQuery();

                //criar mysqldataapter para preencher os dados no data table
                MySqlDataAdapter da = new MySqlDataAdapter(executacmd);
                da.Fill(tabelaProdutos);

                conexao.Close();


                return tabelaProdutos;


            }
            catch (Exception erro)
            {
                //MessageBox.Show("Erro ao executar o comando sql: " + erro);
                FrmMessageBox mensagem = new FrmMessageBox();
                mensagem.Mensagem("erro dao compra" + erro);
                mensagem.ShowDialog();
                return null;
            }

        }


        #endregion






        #region listar

        public DataTable ListarProdutosFinalizar()
        {
            try
            {
                //criar datatable e comando sql
                DataTable tabelaProdutos = new DataTable();



                string sql = @"
                                SELECT 
                                    tb_carrinho.nome_produto AS 'Produto',
                                    tb_carrinho.qtd_estoque AS 'Quantidade',
                                    (tb_carrinho.preco_produto * tb_carrinho.qtd_estoque) AS 'Total'
                                FROM 
                                    tb_carrinho;";


                //organizar o comando e executar
                MySqlCommand executacmd = new MySqlCommand(sql, conexao);

                conexao.Open();
                executacmd.ExecuteNonQuery();

                //criar mysqldataapter para preencher os dados no data table
                MySqlDataAdapter da = new MySqlDataAdapter(executacmd);
                da.Fill(tabelaProdutos);

                conexao.Close();


                return tabelaProdutos;


            }
            catch (Exception erro)
            {
                //MessageBox.Show("Erro ao executar o comando sql: " + erro);
                FrmMessageBox mensagem = new FrmMessageBox();
                mensagem.Mensagem("erro dao compra" + erro);
                mensagem.ShowDialog();
                return null;
            }

        }


        #endregion



    }
}
