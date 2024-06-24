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
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Data;

namespace TESTE_GUNA.projeto.dao
{
    public class AdministradorDAO
    {

        //Conecta com o Banco de dados
        private MySqlConnection conexao;

        //Construtor
        public AdministradorDAO()
        {
            this.conexao = new ConnectionFactory().getconnection();
        }

        #region Login
        public bool EfetuarLoginAdministrador(string email, string senha)
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


                    FrmMenu tela = new FrmMenu();
                    return false;
                }

            }
            catch (Exception erro)
            {
                System.Windows.Forms.MessageBox.Show("Erro Identificado:" + erro);
                return false;
            }

        }
        #endregion

        #region CadastroAdmnistrador
        public void CadastrarAdministrador(Administrador obj)
        {
            try
            {
                // Definindo comando SQL
                string sql = @"INSERT INTO tb_administrador (
                           cnpj_administrador, nome_administrador, email_administrador, telefone_administrador, 
                           celular_administrador, senha_administrador, nivel_acesso, cep_administrador, 
                           endereco_administrador, numero_administrador, complemento_administrador, 
                           bairro_administrador, cidade_administrador, estado_administrador)
                       VALUES (
                           @cnpj_administrador, @nome_administrador, @email_administrador, @telefone_administrador, 
                           @celular_administrador, @senha_administrador, @nivel_acesso, @cep_administrador, 
                           @endereco_administrador, @numero_administrador, @complemento_administrador, 
                           @bairro_administrador, @cidade_administrador, @estado_administrador)";

                // Organizando comando SQL
                MySqlCommand executacmd = new MySqlCommand(sql, conexao);

                executacmd.Parameters.AddWithValue("@cnpj_administrador", obj.cnpj);
                executacmd.Parameters.AddWithValue("@nome_administrador", obj.nome);
                executacmd.Parameters.AddWithValue("@email_administrador", obj.email);
                executacmd.Parameters.AddWithValue("@telefone_administrador", obj.telefone);
                executacmd.Parameters.AddWithValue("@celular_administrador", obj.celular);
                executacmd.Parameters.AddWithValue("@senha_administrador", obj.senha);
                executacmd.Parameters.AddWithValue("@nivel_acesso", obj.nivel);
                executacmd.Parameters.AddWithValue("@cep_administrador", obj.cep);
                executacmd.Parameters.AddWithValue("@endereco_administrador", obj.endereco);
                executacmd.Parameters.AddWithValue("@numero_administrador", obj.numero);
                executacmd.Parameters.AddWithValue("@complemento_administrador", obj.complemento);
                executacmd.Parameters.AddWithValue("@bairro_administrador", obj.bairro);
                executacmd.Parameters.AddWithValue("@cidade_administrador", obj.cidade);
                executacmd.Parameters.AddWithValue("@estado_administrador", obj.estado);

                // Abrindo conexão e aplicando SQL
                conexao.Open();
                executacmd.ExecuteNonQuery();

                // Fechando conexão
                conexao.Close();
            }
            catch (Exception erro)
            {
                System.Windows.Forms.MessageBox.Show("Erro Identificado:" + erro);
            }
        }





        #endregion


        //#region ConsultarAdministradorPorCNPJ
        //private void CarregarDadosAdministrador(string obj)
        //{
        //    try
        //    {
        //        // Implemente a lógica para recuperar os dados do administrador cadastrado
        //        // Pode ser uma consulta SQL SELECT ou qualquer outra forma de acesso aos dados

        //        string sql = "SELECT * FROM tb_administrador WHERE cnpj_administrador = @cnpj";
        //        MySqlCommand executacmd = new MySqlCommand(sql, conexao);

        //        executacmd.Parameters.AddWithValue("@cnpj_administrador", obj.cnpj);
        //        conexao.Open();
        //        MySqlDataReader reader = executacmd.ExecuteReader();

        //        if (reader.Read())
        //        {
        //            // Atribuir os valores recuperados às TextBoxes correspondentes
        //            txtNome.Text = reader["nome_administrador"].ToString();
        //            txtEstado.Text = reader["estado_administrador"].ToString();
        //            txtCidade.Text = reader["cidade_administrador"].ToString();
        //            txtEndereco.Text = reader["endereco_administrador"].ToString();
        //            txtComplemento.Text = reader["complemento_administrador"].ToString();
        //            txtEmail.Text = reader["email_administrador"].ToString();
        //            txtSenha.Text = reader["senha_administrador"].ToString();
        //            txtCPNJ.Text = reader["cnpj_administrador"].ToString();
        //            txtCEP.Text = reader["cep_administrador"].ToString();
        //            txtBairro.Text = reader["bairro_administrador"].ToString();
        //            txtNum.Text = reader["numero_administrador"].ToString();
        //            // Preencher outras TextBoxes conforme necessário
        //        }

        //        reader.Close();
        //    }
        //    catch (Exception erro)
        //    {
                
        //    }
        //    finally
        //    {
        //        conexao.Close();
        //    }
        //    #endregion
        //}

    }
    





}


    


