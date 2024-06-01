using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient; // Import the correct MySqlConnection

using System.Windows.Forms;
using System.Data;
using System.Security.Cryptography.X509Certificates;
using Mysqlx;

using TESTE_GUNA.projet.conexao;
using TESTE_GUNA.projeto.model;
using TESTE_GUNA.projeto.dao;

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
                            values(@nomeCliente,@cpfcnpjCliente,@emailCliente,@senhaCliente, @nivelAcesso)";


                //Organizando comando SQL
                MySqlCommand executacmd = new MySqlCommand(sql, conexao);

                executacmd.Parameters.AddWithValue("@nomeCliente", obj.nome_cliente);
                executacmd.Parameters.AddWithValue("@cpfcnpjCliente", obj.cpf_cnpj_cliente);
                executacmd.Parameters.AddWithValue("@emailCliente", obj.email_cliente);
                executacmd.Parameters.AddWithValue("@senhaCliente", obj.senha_cliente);
                executacmd.Parameters.AddWithValue("@nivelAcesso", obj.nivel_acesso);


                //Abrindo conexao e aplicando sql
                conexao.Open();
                executacmd.ExecuteNonQuery();
                MessageBox.Show("Cliente cadastrado com sucesso!");
                //fechando conexao
                conexao.Close();

            }
            catch (Exception erro)
            {

                MessageBox.Show("Erro Identificado:" + erro);
            }
        }
        #endregion
    }
}
