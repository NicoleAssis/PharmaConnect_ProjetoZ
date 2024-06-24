using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TESTE_GUNA.projet.conexao;
using TESTE_GUNA.projeto.model;
using TESTE_GUNA.projeto.view;


using System.Diagnostics.Eventing.Reader;
using System.Windows.Forms;
using System.Globalization;
using System.Data;

namespace TESTE_GUNA.projeto.dao
{
    public class ProdutoDAO
    {

        //Conecta com o Banco de dados
        private MySqlConnection conexao;

        //Construtor
        public ProdutoDAO()
        {
            this.conexao = new ConnectionFactory().getconnection();
        }

       


        #region CadastroProduto

        public void CadastrarProduto(Produto obj)
        {
            try
            {

                //Definindo comando SQL
                string sql = @"insert into tb_produto (nome_produto, desc_produto, preco_produto, qtd_estoque, departamento)
                            values(@nomeProduto,@descProduto,@precoProduto,@qtdEstoque,@departamento)";


                //Organizando comando SQL
                MySqlCommand executacmd = new MySqlCommand(sql, conexao);

                executacmd.Parameters.AddWithValue("@nomeProduto", obj.nomeProduto);
                executacmd.Parameters.AddWithValue("@descProduto", obj.descProduto);
                executacmd.Parameters.AddWithValue("@precoProduto", obj.precoProduto);
                executacmd.Parameters.AddWithValue("@qtdEstoque", obj.qtdEstoque);
                executacmd.Parameters.AddWithValue("@departamento", obj.departamento);

               


                //Abrindo conexao e aplicando sql
                conexao.Open();
                executacmd.ExecuteNonQuery();

                //fechando conexao
                conexao.Close();

                FrmMessageBox mensagem = new FrmMessageBox();


                mensagem.Mensagem("PRODUTO CRIADO COM SUCESSO!");
                mensagem.ShowDialog();



            }
            catch (Exception erro)
            {
                

                MessageBox.Show(erro.Message);
            }


                    
            
        

        }
        #endregion


        #region Método LIstar Produto
        public DataTable LIstarProdutos()
        {
            try
            {

                //1 passo criar datatable e comando sql

                DataTable DataGridViewVendas = new DataTable();
                //PRIMEIRO TESTAR COMANDO NO SQL DEPOIS COLOCAR NO C#
                string sql = @"select  id_produto as 'ID Produto' ,nome_produto 'Nome Produto', 
                                        desc_produto 'Descrição', 
                                        preco_produto 'Preço', qtd_estoque 'Qtd Estoque', 
                                        departamento 'Departamentos'  from tb_produto;";

                //2 passo organizar comando e executar
                MySqlCommand executacmd = new MySqlCommand(sql, conexao);
                conexao.Open();
                executacmd.ExecuteNonQuery();


                //3 passo criar mysqldataapter para preencher dados no datatable
                MySqlDataAdapter da = new MySqlDataAdapter(executacmd);
                da.Fill(DataGridViewVendas);//preencher


                //fechar a conexao com o banco de dados
                conexao.Close();


                return DataGridViewVendas;

            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao executar o comando sql: " + erro);
                return null;
            }


        }

        #endregion

        #region Alterar Produto
        public void AlterarProduto(Produto obj)
        {
            try
            {

                //Definindo comando SQL
                string sql = @"update tb_produto set  desc_produto=@desc_produto, 
                            preco_produto=@preco_produto, qtd_estoque=@qtd_estoque, departamento=@departamento where nome_produto=@nome_produto";
                          


                //Organizando comando SQL
                MySqlCommand executacmd = new MySqlCommand(sql, conexao);

                
                executacmd.Parameters.AddWithValue("@nome_produto", obj.nomeProduto);
                executacmd.Parameters.AddWithValue("@desc_produto", obj.descProduto);
                executacmd.Parameters.AddWithValue("@preco_produto", obj.precoProduto);
                executacmd.Parameters.AddWithValue("@qtd_estoque", obj.qtdEstoque);
                executacmd.Parameters.AddWithValue("@departamento", obj.departamento);
                executacmd.Parameters.AddWithValue("@id_produto", obj.idproduto);




                //Abrindo conexao e aplicando sql
                conexao.Open();
                executacmd.ExecuteNonQuery();

                //fechando conexao
                conexao.Close();

               


                



            }
            catch (Exception erro)
            {


                MessageBox.Show(erro.Message);
            }






        }

        #endregion

        #region Excluir Produto

        public void ExcluirProduto(Produto obj)
        {
            try
            {

                //Definindo comando SQL
                string sql = @"delete from tb_produto where nome_produto=@nome_produto";


                //Organizando comando SQL
                MySqlCommand executacmd = new MySqlCommand(sql, conexao);


                executacmd.Parameters.AddWithValue("@nome_produto", obj.nomeProduto);




                //Abrindo conexao e aplicando sql
                conexao.Open();
                executacmd.ExecuteNonQuery();

                //fechando conexao
                conexao.Close();

                FrmMessageBox mensagem = new FrmMessageBox();


                mensagem.Mensagem("PRODUTO EXCLUIDO COM SUCESSO!");
                mensagem.ShowDialog();



            }
            catch (Exception erro)
            {


                MessageBox.Show(erro.Message);
            }






        }

        #endregion

        #region MétodoLIstarProdutoPorNome
        public DataTable LIstarProdutosPorNome(string nome)
        {
            try
            {

                //1 passo criar datatable e comando sql

                DataTable DataGridViewVendas = new DataTable();
                //PRIMEIRO TESTAR COMANDO NO SQL DEPOIS COLOCAR NO C#
                string sql = @"select  id_produto as 'ID Produto' ,nome_produto 'Nome Produto', 
                                        desc_produto 'Descrição', 
                                        preco_produto 'Preço', qtd_estoque 'Qtd Estoque', 
                                        departamento 'Departamentos'  from tb_produto where nome_produto like @nome_produto";

                //2 passo organizar comando e executar
                MySqlCommand executacmd = new MySqlCommand(sql, conexao);
                executacmd.Parameters.AddWithValue("@nome_produto", nome);
                conexao.Open();
                executacmd.ExecuteNonQuery();


                //3 passo criar mysqldataapter para preencher dados no datatable
                MySqlDataAdapter da = new MySqlDataAdapter(executacmd);
                da.Fill(DataGridViewVendas);//preencher


                //fechar a conexao com o banco de dados
                conexao.Close();


                return DataGridViewVendas;

            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao executar o comando sql: " + erro);
                return null;
            }


        }

        #endregion

        #region MétodoBuscarProdutoPorNome
        public DataTable BuscarProdutosPorNome(string nome)
        {
            try
            {

                //1 passo criar datatable e comando sql

                DataTable tabelaProdutos = new DataTable();
                //PRIMEIRO TESTAR COMANDO NO SQL DEPOIS COLOCAR NO C#
                string sql = @"select  id_produto as 'ID Produto' ,nome_produto 'Nome Produto', 
                                        desc_produto 'Descrição', 
                                        preco_produto 'Preço', qtd_estoque 'Qtd Estoque', 
                                        departamento 'Departamentos'  from tb_produto where nome_produto = @nome_produto";

                //2 passo organizar comando e executar
                MySqlCommand executacmd = new MySqlCommand(sql, conexao);
                executacmd.Parameters.AddWithValue("@nome_produto", nome);
                conexao.Open();
                executacmd.ExecuteNonQuery();


                //3 passo criar mysqldataapter para preencher dados no datatable
                MySqlDataAdapter da = new MySqlDataAdapter(executacmd);
                da.Fill(tabelaProdutos);//preencher


                //fechar a conexao com o banco de dados
                conexao.Close();


                return tabelaProdutos;

            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao executar o comando sql: " + erro);
                return null;
            }


        }

        #endregion
    }
}
