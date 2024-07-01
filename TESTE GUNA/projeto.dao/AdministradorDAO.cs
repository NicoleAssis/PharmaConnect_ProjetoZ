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

        #region CadastroAdministrador1

        public void CadastrarAdministador1(Administrador obj)
        {
            try
            {
                // Definindo comando SQL
                string sql = @"insert into tb_administrador (cnpj_administrador ,nome_administrador ,email_administrador ,telefone_administrador ,celular_administrador, cep_administrador, endereco_administrador, numero_administrador,complemento_administrador, bairro_administrador, cidade_administrador, estado_administrador,senha_administrador,nivel_acesso)
                    values(@cnpj_administrador,@nome_administrador,@email_administrador,@telefone_administrador,@celular_administrador,@cep_administrador,@endereco_administrador,@numero_administrador,@complemento_administrador,@bairro_administrador,@cidade_administrador,@estado_administrador,@senha_administrador,@nivel_acesso)";

                // Organizando comando SQL
                MySqlCommand executacmd = new MySqlCommand(sql, conexao);

                executacmd.Parameters.AddWithValue("@cnpj_administrador", obj.cnpj);
                executacmd.Parameters.AddWithValue("@nome_administrador", obj.nome);
                executacmd.Parameters.AddWithValue("@email_administrador", obj.email);
                executacmd.Parameters.AddWithValue("@telefone_administrador", obj.telefone);
                executacmd.Parameters.AddWithValue("@celular_administrador", obj.celular);
                executacmd.Parameters.AddWithValue("@cep_administrador", obj.cep);
                executacmd.Parameters.AddWithValue("@endereco_administrador", obj.endereco);
                executacmd.Parameters.AddWithValue("@numero_administrador", obj.numero);
                executacmd.Parameters.AddWithValue("@complemento_administrador", obj.complemento);
                executacmd.Parameters.AddWithValue("@bairro_administrador", obj.bairro);
                executacmd.Parameters.AddWithValue("@cidade_administrador", obj.cidade);
                executacmd.Parameters.AddWithValue("@estado_administrador", obj.estado);
                executacmd.Parameters.AddWithValue("@senha_administrador", obj.senha);
               

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

        #region CadastroAdministrador2
        public void CadastrarAdministador2(Administrador obj)
        {

            try
            {
                // Definindo comando SQL
                string sql = @"insert into tb_administrador (cnpj_administrador ,nome_administrador ,email_administrador ,telefone_administrador ,celular_administrador, cep_administrador, endereco_administrador, numero_administrador,complemento_administrador, bairro_administrador, cidade_administrador, estado_administrador,senha_administrador,nivel_acesso)
                    values(@cnpj_administrador,@nome_administrador,@email_administrador,@telefone_administrador,@celular_administrador,@cep_administrador,@endereco_administrador,@numero_administrador,@complemento_administrador,@bairro_administrador,@cidade_administrador,@estado_administrador,@senha_administrador,@nivel_acesso)";

                // Organizando comando SQL
                MySqlCommand executacmd = new MySqlCommand(sql, conexao);

                executacmd.Parameters.AddWithValue("@cnpj_administrador", obj.cnpj);
                executacmd.Parameters.AddWithValue("@nome_administrador", obj.nome);
                executacmd.Parameters.AddWithValue("@email_administrador", obj.email);
                executacmd.Parameters.AddWithValue("@telefone_administrador", obj.telefone);
                executacmd.Parameters.AddWithValue("@celular_administrador", obj.celular);
                executacmd.Parameters.AddWithValue("@cep_administrador", obj.cep);
                executacmd.Parameters.AddWithValue("@endereco_administrador", obj.endereco);
                executacmd.Parameters.AddWithValue("@numero_administrador", obj.numero);
                executacmd.Parameters.AddWithValue("@complemento_administrador", obj.complemento);
                executacmd.Parameters.AddWithValue("@bairro_administrador", obj.bairro);
                executacmd.Parameters.AddWithValue("@cidade_administrador", obj.cidade);
                executacmd.Parameters.AddWithValue("@estado_administrador", obj.estado);
                executacmd.Parameters.AddWithValue("@senha_administrador", obj.senha);
               

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

        #region ValidarCPNJ
        public static bool ValidarCNPJ(string cnpj)
        {
            // Remove caracteres não numéricos
            cnpj = Regex.Replace(cnpj, "[^0-9]", "");

            // Verifica se o CNPJ tem 14 dígitos
            if (cnpj.Length != 14)
                return false;

            // Verifica se todos os dígitos são iguais (caso raro de erro)
            if (cnpj.All(x => x == cnpj[0]))
                return false;

            // Calcula os dígitos verificadores
            int[] multiplicadores1 = { 5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2 };
            int[] multiplicadores2 = { 6, 5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2 };

            string tempCnpj = cnpj.Substring(0, 12);
            int soma = 0;

            for (int i = 0; i < 12; i++)
            {
                soma += int.Parse(tempCnpj[i].ToString()) * multiplicadores1[i];
            }

            int resto = soma % 11;
            int digito1 = resto < 2 ? 0 : 11 - resto;

            tempCnpj += digito1;
            soma = 0;

            for (int i = 0; i < 13; i++)
            {
                soma += int.Parse(tempCnpj[i].ToString()) * multiplicadores2[i];
            }

            resto = soma % 11;
            int digito2 = resto < 2 ? 0 : 11 - resto;

            tempCnpj += digito2;

            // Verifica se os dígitos calculados são iguais aos informados
            return cnpj.EndsWith(tempCnpj.Substring(12));
        }

        #endregion


    }
}
