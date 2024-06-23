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
                string sql = @"insert into tb_produtos (nome_produto, desc_produto, preco_produto, qtd_estoque, departamento)
                            values(@nomeProduto,@descProduto,@precoProduto,@qtdEstoque,@departamento)";


                //Organizando comando SQL
                MySqlCommand executacmd = new MySqlCommand(sql, conexao);

                executacmd.Parameters.AddWithValue("@nomeProduto", obj.nomeProduto);
                executacmd.Parameters.AddWithValue("@descProduto", obj.descProduto);
                executacmd.Parameters.AddWithValue("@precoProduto", obj.precoProduto);
                executacmd.Parameters.AddWithValue("@qtdEstoque", obj.qtdEstoque);
                executacmd.Parameters.AddWithValue("@departamento", obj.departamento);


                ;

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

        


        #region Listar Produtos

        public DataTable ListarProdutos()
        {
            try
            {
                //criar datatable e comando sql
                DataTable tabelProdutos = new DataTable();


                //CODIGO PARA PERSONALIZAR VISUALIZACAO DO DATA GRID VIEW

                /*              VISUALIZACAO DO NOME DA TABELA
                 * select tb_produtos.id_produto,
                 *      tb_produtos.nome_produto ,
                 *      tb_produtos.desc_produto as 'Preço',
                 *      tb_produtos.preco_produto as 'Qtd no Estoque',
                 *      
                 *            CONECTAR DIFERENTES TABELAS
                 *      tb_fornecedores.nome as 'Fornecedores' from tb_produtos
                 *    JUNTA AS TABELA          CHAVE ESTRANGEIRA           CHAVE PRIMARIA
                 *      join tb_fornecedores on (tb_produtos.for_id = tb_fornecedores.id);
                 */




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
    

    }
}
