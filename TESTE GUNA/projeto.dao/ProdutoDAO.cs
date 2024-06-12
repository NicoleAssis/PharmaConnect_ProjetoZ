using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TESTE_GUNA.projet.conexao;
using TESTE_GUNA.projeto.model;
using TESTE_GUNA.projeto.view;
using System.Windows.Forms;

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

        #region Methodoso

        #region Cadastrar produto
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
                    int nivel = reader.GetInt32(14);

                    //Testando dados testados do banco



                    /*
                     * 
                     * 
                     * 
                     * 
                     * ADICIONAR FORM DE CLIENTE LOGADO COM SUCESSO 
                     * 
                     * 
                     * 
                     * 
                     * */

                    FrmMenu menuCliente = new FrmMenu();
                    AdmFrmMenu menuAdm = new AdmFrmMenu();


                    if (nivel.Equals(2))
                    {
                        menuCliente.Show();
                    }
                    else if (nivel.Equals(1))
                    {
                        menuAdm.Show();

                    }


                    return true;
                }
                else
                {
                    /*
                    * 
                    * 
                    * 
                    * 
                    * ADICIONAR FORM SE SENHA OU EMAIL INCORRETOS
                    * 
                    * 
                    * 
                    * 
                    * */

                    Helpers limparTela = new Helpers();


                    FrmLogin tela = new FrmLogin();
                    return false;
                }

            }
            catch (Exception erro)
            {
                MessageBox.Show("Aconteceu o erro: " + erro);
                return false;
            }

        }
        #endregion
        #endregion
    }
}
