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
using TESTE_GUNA.projeto.view;
using System.Diagnostics.Eventing.Reader;

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

        #region Login Cliente
        public bool EfetuarLoginCliente(string email, string senha)
        {
            try
            {
                //criando comando sql
                string sql = @"select * from tb_clientes                        
'                               where email_cliente = @email_cliente and senha_cliente = @senha_cliente";

                //Organizando e executando sql
                MySqlCommand executacmd = new MySqlCommand(@sql, conexao);
                executacmd.Parameters.AddWithValue("@email_cliente", email);
                executacmd.Parameters.AddWithValue("@senha_cliente", senha);

                conexao.Open();

                MySqlDataReader reader = executacmd.ExecuteReader();


                //methodo leitor de dados
                //se conseguir ler os dados
                if (reader.Read())
                {
                    //pega as info 
                    string nivel = reader.GetString("nivel_acesso");
                    string nome = reader.GetString("nome_cliente");

                    MessageBox.Show("Login realizado com sucesso !" +nome +nivel);

                    //criada uma string temporária para nome 

                    string temp = nome;
                    //NIVEIS DE ACESSO
                    AdmFrmMenu telamenuadm = new AdmFrmMenu();
                    FrmMenu telamenucliente = new FrmMenu();


                    if (nivel.Equals(1))
                    {
                        //Administrador
                        telamenuadm.Show();
                        

                    }
                    else if (nivel.Equals(1))
                    {
                        //Cliente
                        telamenucliente.Show();
                        
                    }
                    return true;
                }
                else
                {
                    //login errado pq nn resultou em nenhuma conta
                    MessageBox.Show("Email ou senha incorretos!");

                    Helpers limparTela = new Helpers();
                    FrmLogin tela = new FrmLogin();
                    return false;
                }
                    
            }
            catch (Exception  erro)
            {

                MessageBox.Show("Aconteeu o erro (efetuar login)" + erro);
                return false;
            }
        }
        #endregion
    }
}
