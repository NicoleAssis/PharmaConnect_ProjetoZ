using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TESTE_GUNA.projet.conexao;
using TESTE_GUNA.projeto.model;
using TESTE_GUNA.projeto.view;

namespace TESTE_GUNA.projeto.dao
{
    public class SenhaDAO
    {
        //Conecta com o Banco de dados
        private MySqlConnection conexao;


        //Construtor
        public SenhaDAO()
        {
            this.conexao = new ConnectionFactory().getconnection();

        }

        public string senhaDoCliente;

        #region ConfirmarSenha

        public bool ConfirmarSenha (string senhaAtual)
        {
            try
            {
                PagamentoDAO pagamentoDAO = new PagamentoDAO();
                int idCliente = pagamentoDAO.RetornaIdCliente();


                //PRIMEIRO TESTAR COMANDO NO SQL DEPOIS COLOCAR NO C#
                string sql = "SELECT senha_cliente FROM tb_clientes WHERE id = @ClienteId";

                //2 passo organizar comando e executar
                MySqlCommand executacmd = new MySqlCommand(sql, conexao);
                executacmd.Parameters.AddWithValue("@ClienteId", idCliente);


                conexao.Open();
                executacmd.ExecuteNonQuery();


                object result = executacmd.ExecuteScalar();


                if (result != null)
                {
                    senhaDoCliente = Convert.ToString(result);
                }


                conexao.Close();

                //se a senha do banco de dados do cliente for igual a digitada
                if (senhaDoCliente == senhaAtual)
                {
                    return true;
                }
                else
                {
                    return false;
                }

            }
            catch (Exception Erro)
            {
                TelaMessageBox message = new TelaMessageBox();
                message.Mensagem("ERRO confirmar senha:  " + Erro);
                throw;
            }

        }


        #endregion




        #region AlterarSenha


        public void AlterarSenha(string senhaNova)
        {
            try
            {
                PagamentoDAO pagamentoDAO = new PagamentoDAO();
                int idCliente = pagamentoDAO.RetornaIdCliente();


                //PRIMEIRO TESTAR COMANDO NO SQL DEPOIS COLOCAR NO C#
                string sql = "UPDATE tb_clientes SET senha_cliente = @NovaSenha WHERE id = @IdCliente";

                //2 passo organizar comando e executar
                MySqlCommand executacmd = new MySqlCommand(sql, conexao);
                executacmd.Parameters.AddWithValue("@NovaSenha", senhaNova);
                executacmd.Parameters.AddWithValue("@IdCliente", idCliente);
                 


                conexao.Open();
                executacmd.ExecuteNonQuery();


                conexao.Close();

                

            }
            catch (Exception Erro)
            {
                TelaMessageBox message = new TelaMessageBox();
                message.Mensagem("ERRO alterar senha:  " + Erro);
                throw;
            }


        }




        #endregion



    }
}
