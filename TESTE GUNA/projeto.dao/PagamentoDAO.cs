using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TESTE_GUNA.projet.conexao;
using TESTE_GUNA.projeto.model;
using TESTE_GUNA.projeto.view;
using TESTE_GUNA.projeto.dao;

namespace TESTE_GUNA.projeto.dao
{
    public class PagamentoDAO
    {

        //Conecta com o Banco de dados
        private MySqlConnection conexao;


        //Construtor
        public PagamentoDAO()
        {
            this.conexao = new ConnectionFactory().getconnection();

        }


        #region RetornaIdCliente

        public int RetornaIdCliente()
        {
            int clienteId = -1;

            try
            {
                string email = FrmLogin.TelaPagamento.Email;
                string senha = FrmLogin.TelaPagamento.Senha;


                //PRIMEIRO TESTAR COMANDO NO SQL DEPOIS COLOCAR NO C#
                string sql = "SELECT id FROM tb_clientes WHERE email_cliente = @Email AND senha_cliente = @Senha";

                //2 passo organizar comando e executar
                MySqlCommand executacmd = new MySqlCommand(sql, conexao);
                executacmd.Parameters.AddWithValue("@Email", email);
                executacmd.Parameters.AddWithValue("@Senha", senha);

                conexao.Open();
                executacmd.ExecuteNonQuery();


                object result = executacmd.ExecuteScalar();


                if (result != null)
                {
                    clienteId = Convert.ToInt32(result);
                }

                

                conexao.Close();

                return clienteId;

            }
            catch (Exception Erro)
            {
                FrmMessageBox message = new FrmMessageBox();
                message.Mensagem("ERRO RETORNA ID CLIENTE:  " + Erro);
                throw;
            }
            
        }


        #endregion


        #region CadastrarCompra

        public void CadastrarCompra (FormaPagamento obj)
        {
            try
            {
                //1 passo definir comando sql - insert into

                string sql = @"INSERT INTO tb_pagamento (tipo_pag, num_cartao, mes, ano, cvv, id_cliente) 
               VALUES (@tipo_pag, @num_cartao, @mes, @ano, @cvv, @id_cliente)";

                //2 passo organizar comando sql 


                PagamentoDAO dao = new PagamentoDAO();
                int idCliente = dao.RetornaIdCliente();



                MySqlCommand executacmd = new MySqlCommand(sql, conexao);

                executacmd.Parameters.AddWithValue("@tipo_pag", obj.tipoPagamento);
                executacmd.Parameters.AddWithValue("@num_cartao", obj.numCartao);
                executacmd.Parameters.AddWithValue("@mes", obj.mes);
                executacmd.Parameters.AddWithValue("@ano", obj.ano);
                executacmd.Parameters.AddWithValue("@cvv", obj.cvv);
                executacmd.Parameters.AddWithValue("@id_cliente", obj.idCliente);


                //3 passo abrir a conexao e abrir comando sql
                conexao.Open();
                executacmd.ExecuteNonQuery();

                //fechar a conexao com o banco de dados
                conexao.Close();

            }
            catch (Exception erro)
            {
                FrmMessageBox messageBox = new FrmMessageBox();
                messageBox.Mensagem("Aconteceu o erro:" + erro);
                messageBox.ShowDialog();
            }









        }


        #endregion



    }
}
