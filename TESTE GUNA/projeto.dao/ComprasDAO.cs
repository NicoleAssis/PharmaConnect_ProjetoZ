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
                                    tb_carrinho.qtd_estoque AS 'Quantidade',
                                    tb_carrinho.preco_produto AS 'Preço Unitário',
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
