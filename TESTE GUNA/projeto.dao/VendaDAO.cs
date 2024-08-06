using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using TESTE_GUNA.projet.conexao;
using TESTE_GUNA.projeto.model;



namespace TESTE_GUNA.projeto.dao
{
    public class VendaDAO : Venda
    {
        //Conecta com o Banco de dados
        private MySqlConnection conexao;

        public VendaDAO()
        {
            this.conexao = new ConnectionFactory().getconnection();
        }

        #region Cadastro Pagamento PIX
        public void CadastroPagamentoPix(VendaDAO obj)
        {

            //Definindo comando SQL
            string sql = @"INSERT INTO tb_vendas (cliente_id, total_venda, id_pagamento, tipo_pag, num_cartao, mes, ano, cvv) 
                               VALUES (@cliente_id, @total, 1, 'Pix', NULL, NULL, NULL, NULL);";


            //Organizando comando SQL
            MySqlCommand executacmd = new MySqlCommand(sql, conexao);
            int id_conectado = ClienteDAO.id_conectado;
            //int qtdInicial = 1;
            executacmd.Parameters.AddWithValue("@cliente_id", id_conectado);
            executacmd.Parameters.AddWithValue("@total", obj.total_venda);






            //Abrindo conexao e aplicando sql
            conexao.Open();
            executacmd.ExecuteNonQuery();

            //fechando conexao
            conexao.Close();

        }



        #endregion

        #region Cadastro Pagamento Debito
        public void CadastroPagamentoDebito(VendaDAO obj)
        {

            //Definindo comando SQL
            string sql = @"INSERT INTO tb_vendas (cliente_id, total_venda, id_pagamento, tipo_pag, num_cartao, mes, ano, cvv) 
                               VALUES (@cliente_id, @total, 2, 'Débito', @numCartao,@mes, @ano, @cvv);";


            //Organizando comando SQL
            MySqlCommand executacmd = new MySqlCommand(sql, conexao);
            int id_conectado = ClienteDAO.id_conectado;
            //int qtdInicial = 1;
            executacmd.Parameters.AddWithValue("@cliente_id", id_conectado);
            executacmd.Parameters.AddWithValue("@total", obj.total_venda);
            executacmd.Parameters.AddWithValue("@numCartao", obj.num_cartao);
            executacmd.Parameters.AddWithValue("@mes", obj.mes);
            executacmd.Parameters.AddWithValue("@ano", obj.ano);
            executacmd.Parameters.AddWithValue("@cvv", obj.cvv);
            //Abrindo conexao e aplicando sql
            conexao.Open();
            executacmd.ExecuteNonQuery();

            //fechando conexao
            conexao.Close();

        }



        #endregion

        #region Cadastro Pagamento Credito
        public void CadastroPagamentoCredito(VendaDAO obj)
        {

            //Definindo comando SQL
            string sql = @"INSERT INTO tb_vendas (cliente_id, total_venda, id_pagamento, tipo_pag, num_cartao, mes, ano, cvv) 
                               VALUES (@cliente_id, @total, 3, 'Crédito', @numCartao,@mes, @ano, @cvv);";


            //Organizando comando SQL
            MySqlCommand executacmd = new MySqlCommand(sql, conexao);
            int id_conectado = ClienteDAO.id_conectado;
            //int qtdInicial = 1;
            executacmd.Parameters.AddWithValue("@cliente_id", id_conectado);
            executacmd.Parameters.AddWithValue("@total", obj.total_venda);
            executacmd.Parameters.AddWithValue("@numCartao", obj.num_cartao);
            executacmd.Parameters.AddWithValue("@mes", obj.mes);
            executacmd.Parameters.AddWithValue("@ano", obj.ano);
            executacmd.Parameters.AddWithValue("@cvv", obj.cvv);
            //Abrindo conexao e aplicando sql
            conexao.Open();
            executacmd.ExecuteNonQuery();

            //fechando conexao
            conexao.Close();

        }



        #endregion

        #region RetornaIdUltimaVenda

        public int RetornaIdUltimaVenda()
        {
            try
            {
                int idvenda = 0;

                string sql = @"select max(id_venda) id from tb_vendas";

                MySqlCommand executacmd = new MySqlCommand(sql, conexao);


                conexao.Open();

                //executa o comando sql e armazena no rs
                MySqlDataReader rs = executacmd.ExecuteReader();

                //se conseguir ler/ se encontrou algo
                if (rs.Read())
                {
                    idvenda = rs.GetInt32(0);
                }

                conexao.Close();

                return idvenda;
                //fechar a conexao com o banco de dados




            }
            catch (Exception erro)
            {
                MessageBox.Show("Aconteceu o erro (RetornaIdUltimaVenda): " + erro);
                return 0;
            }

        }
        #endregion


        #region Listar  vendas
        public DataTable ListarVendas()
        {
            try
            {
                //criar o datatable e o comando sql
                DataTable tabelaHistorico = new DataTable();
                string sql = @"SELECT
                                tb_vendas.id_venda AS 'Codigo',
                                tb_vendas.tipo_pag AS 'Forma Pagamento',
                                tb_vendas.total_venda AS 'Total'
                            FROM
                                tb_vendas;";


                //executar e organizar o comando sql
                MySqlCommand executacmd = new MySqlCommand(sql, conexao);

                conexao.Open();
                executacmd.ExecuteNonQuery();

                //Criar o mysqldataadapter para preencher os dados no datatable
                MySqlDataAdapter da = new MySqlDataAdapter(executacmd);
                da.Fill(tabelaHistorico);

                conexao.Close();

                return tabelaHistorico;
            }
            catch (Exception erro)
            {
                MessageBox.Show("Aconteceu o erro (ListarVendas) : " + erro);
                return null;
            }
        }



        #endregion



    }
}
