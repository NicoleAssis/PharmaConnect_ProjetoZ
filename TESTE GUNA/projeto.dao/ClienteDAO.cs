using MySql.Data.MySqlClient; // Import the correct MySqlConnection
using System;
using System.Windows.Forms;
using TESTE_GUNA.projet.conexao;
using TESTE_GUNA.projeto.model;
using TESTE_GUNA.projeto.view;

namespace TESTE_GUNA.projeto.dao
{
    public class ClienteDAO
    {

        //Conecta com o Banco de dados
        private MySqlConnection conexao;

        public ClienteDAO()
        {
            this.conexao = new ConnectionFactory().getconnection();
        }



        #region CadastroCliente

        public void CadastrarClienteC1(Cliente obj)
        {
            try
            {

                //Definindo comando SQL
                string sql = @"insert into tb_clientes (cpf_cnpj_cliente,nome_cliente,email_cliente,senha_cliente,nivel_acesso )
                            values(@cpf_cnpj_cliente,@nome_cliente,@email_cliente,@senha_cliente,@nivel_acesso)";


                //Organizando comando SQL
                MySqlCommand executacmd = new MySqlCommand(sql, conexao);

                executacmd.Parameters.AddWithValue("@cpf_cnpj_cliente", obj.cpf_cnpj);
                executacmd.Parameters.AddWithValue("@nome_cliente", obj.nome);
                executacmd.Parameters.AddWithValue("@email_cliente", obj.email);
                executacmd.Parameters.AddWithValue("@senha_cliente", obj.senha);
                executacmd.Parameters.AddWithValue("@nivel_acesso", obj.nivel);


                //Abrindo conexao e aplicando sql
                conexao.Open();
                executacmd.ExecuteNonQuery();

                //fechando conexao
                conexao.Close();

            }
            catch (Exception erro)
            {

                MessageBox.Show("Erro Identificado:" + erro);
            }
        }
        #endregion

        #region Login
        public bool EfetuarLogin(string email, string senha)
        {
            try
            {

                //criando sql
                string sql = @"select * from tb_clientes
                                where email_cliente = @email and senha_cliente; = @senha";

                //organizar e executar o sql


                MySqlCommand executacmd = new MySqlCommand(@sql, conexao);
                executacmd.Parameters.AddWithValue("@email", email);
                executacmd.Parameters.AddWithValue("@senha", senha);

                conexao.Open();

                MySqlDataReader reader = executacmd.ExecuteReader();

                //Metódo de Leitura
                if (reader.Read())
                {
                    //nivel = reader.GetString("nivel_acesso");
                    string nome = reader.GetString("nome_cliente");

                    


                    MessageBox.Show("Login realizado com sucesso! Bem vendo(a)" + nome );


                    return true;
                }
                return true;
            }
            catch (Exception)
            {

                return false;
            }
            
        }
        #endregion
    }
}
