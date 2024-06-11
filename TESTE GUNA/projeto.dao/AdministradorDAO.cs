using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using TESTE_GUNA.projet.conexao;
using TESTE_GUNA.projeto.model;
using TESTE_GUNA.projeto.view;
using System.Diagnostics.Eventing.Reader;
using System.Windows;

namespace TESTE_GUNA.projeto.dao
{
    public  class AdministradorDAO
    {

        //Conecta com o Banco de dados
        private MySqlConnection conexao;

        //Construtor
        public AdministradorDAO()
        {
            this.conexao = new ConnectionFactory().getconnection();
        }

        #region Login
        public bool EfetuarLoginAdministrador (string email, string senha)
        {
            try
            {

                //criando sql
                string sql = @"select * from tb_administrador
                                where email_administrador = @email and senha_administrador = @senha";

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
                    string nome = reader.GetString("nome_administrador");
                    int nivel = reader.GetInt32(15);

                    FrmMenu menuCliente = new FrmMenu();
                    AdmFrmMenu menuAdm = new AdmFrmMenu();

                    if (nivel.Equals(1))
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
                MessageBox.Show("Aconteceu o erro " + erro);
                return false;
            }

        }
        #endregion


    }
}
