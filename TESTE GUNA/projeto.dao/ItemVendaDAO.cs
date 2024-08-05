using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using TESTE_GUNA.projet.conexao;
using TESTE_GUNA.projeto.model;

namespace TESTE_GUNA.projeto.dao
{
    public class ItemVendaDAO : ItemVenda
    {

        private MySqlConnection conexao;

        public ItemVendaDAO()
        {
            this.conexao = new ConnectionFactory().getconnection();
        }



        #region CadastrarItem

        public void CadastrarItem(ItemVenda obj)
        {
            try
            {
                string sql = @"insert into tb_itensvendas (venda_id, produto_id, qtd, subtotal) 
                                values (@venda_id, @produto_id, @qtd, @subtotal)";


                //2 passo organizar comando sql 

                MySqlCommand executacmd = new MySqlCommand(sql, conexao);

                executacmd.Parameters.AddWithValue("@venda_id", obj.venda_id);
                executacmd.Parameters.AddWithValue("@produto_id", obj.produto_id);
                executacmd.Parameters.AddWithValue("@qtd", obj.quantidade);
                executacmd.Parameters.AddWithValue("@subtotal", obj.subtotal);


                //3 passo abrir a conexao e abrir o comando sql

                conexao.Open();
                executacmd.ExecuteNonQuery();

                //MessageBox.Show("Venda cadastrada com sucesso!");

                //fechar a conexao com o banco de dados
                conexao.Close();

            }
            catch (Exception erro)
            {
                MessageBox.Show("Aconteceu o erro (CadastrarItem): " + erro);
            }
        }



        #endregion
    }
}
