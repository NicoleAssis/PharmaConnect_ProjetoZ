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
using Guna.UI2.WinForms;
using System.Data.SqlClient;
using TESTE_GUNA.projeto.window;




namespace TESTE_GUNA.projeto.dao
{
    public class ProdutoDAO : Produto
    {

        //Conecta com o Banco de dados
        private MySqlConnection conexao;
        public static List<Produto> list = new List<Produto>();


        //Construtor
        public ProdutoDAO()
        {
            this.conexao = new ConnectionFactory().getconnection();
        }

        #region Search
        public void Search(string key)
        {
            
                string sql = "select * from tb_produto where  nome_produto like @nome;";

                //organizar o comando e executar
                MySqlCommand executacmd = new MySqlCommand(sql, conexao);

                executacmd.Parameters.AddWithValue("@nome", key + "%");
                conexao.Open();

                //responsavel por executar o comando e armazenar os dados do PRODUTO
                MySqlDataReader reader = executacmd.ExecuteReader();



                list.Clear();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        ProdutoDAO p = new ProdutoDAO
                        {
                            Id_Produto = reader.GetInt32(0),
                            nomeProduto = reader.GetString(1),
                            descProduto = reader.GetString(2),
                            precoProduto = reader.GetDecimal(3),
                            qtdEstoque = reader.GetInt32(4),
                            departamento = reader.GetString(5)
                        };
                        list.Add(p);
                    }
                }
                reader.Dispose();
                executacmd.Dispose();
                conexao.Close();
            
           

        }



        #endregion








        #region TotalProdutosCadastrados
        public int contValores()
        {
            try
            {
                int count = 0;
                string sql = "SELECT COUNT(id_produto) As total FROM tb_produto";


                //Organizando comando SQL
                MySqlCommand executacmd = new MySqlCommand(sql, conexao);


                conexao.Open();
                MySqlDataReader reader = executacmd.ExecuteReader();
                if (reader.Read())
                {
                    count = reader.GetInt32(0);
                    conexao.Close();
                }

                return count;





            }
            catch (Exception erro)
            {

                MessageBox.Show("Aconteceu o erro: " + erro);
                throw;
            }


        }
        #endregion


        #region CadastroProduto

        public void CadastrarProduto(Produto obj)
        {
            try
            {

                //Definindo comando SQL
                string sql = @"insert into tb_produtos (nome_produto, desc_produto, preco_produto, qtd_estoque, departamento)
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

                FrmMessageSucess mensagem = new FrmMessageSucess();
                mensagem.MensagemDeSucesso("PRODUTO CRIADO COM SUCESSO!");
                mensagem.ShowDialog();



            }
            catch (Exception erro)
            {


                MessageBox.Show(erro.Message);
            }
        }
        #endregion

        


        #region Listar Produtos

        public DataTable ListarProdutos()
        {
            try
            {
                //criar datatable e comando sql
                DataTable tabelProdutos = new DataTable();


                //CODIGO PARA PERSONALIZAR VISUALIZACAO DO DATA GRID VIEW

                 //            VISUALIZACAO DO NOME DA TABELA
                 //* select tb_produtos.id_produto,
                 //*      tb_produtos.nome_produto ,
                 //*      tb_produtos.desc_produto as 'Preço',
                 //*      tb_produtos.preco_produto as 'Qtd no Estoque',
                 //*      
                 //*            CONECTAR DIFERENTES TABELAS
                 //*      tb_fornecedores.nome as 'Fornecedores' from tb_produtos
                 //*    JUNTA AS TABELA          CHAVE ESTRANGEIRA           CHAVE PRIMARIA
                 //*      join tb_fornecedores on (tb_produtos.for_id = tb_fornecedores.id);
                 




                string sql = @"   SELECT id_produto as 'ID',
                                                    nome_produto as 'Nome',
                                                    desc_produto as 'Descrição',
                                                    preco_produto as  'Preço',
                                                    qtd_estoque as 'Quantidade',
                                                    departamento  as 'Departamento'
                                            FROM tb_produto;";


                //organizar o comando e executar
                MySqlCommand executacmd = new MySqlCommand(sql, conexao);

                conexao.Open();
                executacmd.ExecuteNonQuery();

                //criar mysqldataapter para preencher os dados no data table
                MySqlDataAdapter da = new MySqlDataAdapter(executacmd);
                da.Fill(tabelProdutos);

                conexao.Close();


                return tabelProdutos;


            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao executar o comando sql: " + erro);
                return null;
            }

        }
        #endregion






        #region Get
        public void GetDetails(int detals_id)
        {
            //MessageBox.Show(detals_id.ToString());
            int dt = detals_id;
            string sql = @"select * from tb_produto where id_produto= @id;";

            //organizar o comando e executar
            MySqlCommand executacmd = new MySqlCommand(sql, conexao);
            executacmd.Parameters.AddWithValue("@id", dt);
            conexao.Open();

            //responsavel por executar o comando e armazenar os dados do PRODUTO
            MySqlDataReader reader = executacmd.ExecuteReader();


            //List<Produto> listaProdutos = new List<Produto>

            //se conseguiu ler o rs
            if (reader.Read())
            {
                Produto p = new Produto();

                this.Id_Produto = reader.GetInt32(0);
                this.nomeProduto = reader.GetString(1);
                this.descProduto = reader.GetString(2);
                this.precoProduto = reader.GetDecimal(3);
                this.qtdEstoque = reader.GetInt32(4);
                this.departamento = reader.GetString(5);
                executacmd.Dispose();
                conexao.Close();



            }
            else
            {
                //MessageBox.Show("Nenhum produto encontrado com esse código!");

                conexao.Close();

            }
        }
        #endregion

       


    }

}
