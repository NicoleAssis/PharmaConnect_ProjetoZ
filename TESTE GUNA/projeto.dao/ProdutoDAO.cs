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
        
    }
}
