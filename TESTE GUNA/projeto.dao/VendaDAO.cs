using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

        #region Cadastro Venda
        public void CadastroPagamentoPix(VendaDAO obj)
        {

            //Definindo comando SQL
            string sql = @"INSERT INTO tb_vendas (cliente_id, total_venda, id_pagamento, tipo_pag, num_cartao, mes, ano, cvv) 
                               VALUES (6, @total, 1, 'Pix', NULL, NULL, NULL, NULL);";


            //Organizando comando SQL
            MySqlCommand executacmd = new MySqlCommand(sql, conexao);
            int id_conectado = ClienteDAO.id_conectado;
            //int qtdInicial = 1;
            executacmd.Parameters.AddWithValue("@cliente_id", id_conectado);
            executacmd.Parameters.AddWithValue("@total",obj.total_venda);






            //Abrindo conexao e aplicando sql
            conexao.Open();
            executacmd.ExecuteNonQuery();

            //fechando conexao
            conexao.Close();

        }



        #endregion

    }
}
