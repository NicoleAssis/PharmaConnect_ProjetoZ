using MySql.Data.MySqlClient; // Import the correct MySqlConnection
using System;
using System.Windows.Forms;
using TESTE_GUNA.projet.conexao;
using TESTE_GUNA.projeto.model;
using TESTE_GUNA.projeto.view;
using TESTE_GUNA.projeto.window;
using System.Diagnostics.Eventing.Reader;
using System.Data;
using System.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace TESTE_GUNA.projeto.dao
{
    public class ClienteDAO
    {

        //Conecta com o Banco de dados
        private MySqlConnection conexao;

        public static int id_conectado;
              //retorna como TABELA
        public DataTable listarClientes()
        {
            try
            {

                //1 passo criar datatable e comando sql

                DataTable tabelaCliente = new DataTable();
                //PRIMEIRO TESTAR COMANDO NO SQL DEPOIS COLOCAR NO C#
                string sql = "select * from tb_clientes";

                //2 passo organizar comando e executar
                MySqlCommand executacmd = new MySqlCommand(sql, conexao);
                conexao.Open();
                executacmd.ExecuteNonQuery();


                //3 passo criar mysqldataapter para preencher dados no datatable
                MySqlDataAdapter da = new MySqlDataAdapter(executacmd);
                da.Fill(tabelaCliente);//preencher


                //fechar a conexao com o banco de dados
                conexao.Close();


                return tabelaCliente;

            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao executar o comando sql: " + erro);
                return null;
            }


        }


        public int RetornaIdCliente()
        {
            int clienteId = -1;

            try
            {
                string email = TelaLogin.TelaPagamento.Email;
                string senha = TelaLogin.TelaPagamento.Senha;


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
                //TelaMessageBox message = new TelaMessageBox();
               // message.Mensagem("ERRO RETORNA ID CLIENTE:  " + Erro);
                throw;
            }

        }


        //Construtor
        public ClienteDAO()
        {
            this.conexao = new ConnectionFactory().getconnection();
         
        }



        #region Classes Estáticas
        // Validador Google site  www.macoratti.net/11/09/c_val1.htm
        #region Validação CPF

        public static bool isCpf(string cpf)
        {
            int[] multiplicador1 = new int[9] { 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            int[] multiplicador2 = new int[10] { 11, 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            string tempCpf;
            string digito;
            int soma;
            int resto;
            cpf = cpf.Trim();
            cpf = cpf.Replace(".", "").Replace("-", "");
            if (cpf.Length != 11)
                return false;
            tempCpf = cpf.Substring(0, 9);
            soma = 0;

            for (int i = 0; i < 9; i++)
                soma += int.Parse(tempCpf[i].ToString()) * multiplicador1[i];
            resto = soma % 11;
            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;
            digito = resto.ToString();
            tempCpf = tempCpf + digito;
            soma = 0;
            for (int i = 0; i < 10; i++)
                soma += int.Parse(tempCpf[i].ToString()) * multiplicador2[i];
            resto = soma % 11;
            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;
            digito = digito + resto.ToString();
            return cpf.EndsWith(digito);


        }
        #endregion
        #region RetornarVazio
        //
        public static string MyStringConvert(object o)
        {
            if (o == DBNull.Value || o == null)
                return "";

            return o.ToString();
        }

        public static int MyIntonverter(object o)
        {
            if (o == DBNull.Value || o == null)
                return 0;

            return Convert.ToInt32(o);
        }
        #endregion

        #endregion





        #region Metodos
        #region CadastroCliente

        public void CadastrarClienteC1(Cliente obj)
        {
            try
            {

                //Definindo comando SQL
                string sql = @"insert into tb_clientes (cpf_cliente,nome_cliente,email_cliente,senha_cliente,nivel_acesso )
                            values(@cpf_cliente,@nome_cliente,@email_cliente,@senha_cliente,@nivel_acesso)";


                //Organizando comando SQL
                MySqlCommand executacmd = new MySqlCommand(sql, conexao);

                executacmd.Parameters.AddWithValue("@cpf_cliente", obj.cpf);
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

        #region Buscar dados do banco
        public DataTable buscarDadosClientes(string email,string senha)
        {
            try
            {

                //1 passo criar datatable e comando sql

                DataTable tabelacliente = new DataTable();
                //PRIMEIRO TESTAR COMANDO NO SQL DEPOIS COLOCAR NO C#
                string sql = "select * from tb_clientes where email_cliente  = @email  and senha_cliente = @senha";

                //2 passo organizar comando e executar
                MySqlCommand executacmd = new MySqlCommand(sql, conexao);

                executacmd.Parameters.AddWithValue("@email", email);
                executacmd.Parameters.AddWithValue("@senha", senha);

                conexao.Open();
                executacmd.ExecuteNonQuery();


                //3 passo criar mysqldataapter para preencher dados no datatable
                MySqlDataAdapter da = new MySqlDataAdapter(executacmd);
                da.Fill(tabelacliente);//preencher



                //fechar a conexao com o banco de dados
                conexao.Close();


                return tabelacliente;
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao executar o comando sql: " + erro);
                return null;
            }


        }

        #endregion

        #region Buscar Clientes
        //retorna como TABELA
        public DataTable BuscarClientes()
        {
            try
            {

                //1 passo criar datatable e comando sql

                DataTable tabelaCliente = new DataTable();
                //PRIMEIRO TESTAR COMANDO NO SQL DEPOIS COLOCAR NO C#
                string sql = "select * from tb_clientes ";

                //2 passo organizar comando e executar
                MySqlCommand executacmd = new MySqlCommand(sql, conexao);
                conexao.Open();
                executacmd.ExecuteNonQuery();


                //3 passo criar mysqldataapter para preencher dados no datatable
                MySqlDataAdapter da = new MySqlDataAdapter(executacmd);
                da.Fill(tabelaCliente);//preencher


                //fechar a conexao com o banco de dados
                conexao.Close();


                return tabelaCliente;

            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao executar o comando sql: " + erro);
                return null;
            }


        }
        #endregion

        public void BuscarClientesPorId(int clienteID, TelaPerfil telaPerfil)
        {
            try
            {
                string sql = "SELECT nome_cliente, email_cliente FROM tb_clientes WHERE id=@clienteId";
                MySqlCommand executacmd = new MySqlCommand(sql, conexao);
                executacmd.Parameters.AddWithValue("@clienteId", clienteID);

                conexao.Open();
                MySqlDataReader reader = executacmd.ExecuteReader();

                if (reader.Read())
                {
                    string nome_cliente = reader["nome_cliente"].ToString();
                    string email_cliente = reader["email_cliente"].ToString();

                    telaPerfil.txtNome.Text = nome_cliente;
                    telaPerfil.txtEmail.Text = email_cliente;
                }
                else
                {
                    MessageBox.Show("Cliente não encontrado.");
                }

                reader.Close();
                conexao.Close();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao executar o comando sql: " + erro.Message);
            }
        }


        #endregion

        #region Login
        public bool EfetuarLogin(string email, string senha, TelaLogin telaLogin)
        {
            try
            {

                //criando sql
                string sql = @"select * from tb_clientes
                                where email_cliente = @email and senha_cliente = @senha";

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
                    int nivel =  reader.GetInt32(14);
                    long cpf = reader.GetInt64(1);
                    string nome = MyStringConvert(reader[2]);
                    id_conectado =  MyIntonverter(reader[0]);
                    string telefone = MyStringConvert(reader[4]);
                    string celular = MyStringConvert(reader[5]);
                    string cep = MyStringConvert(reader[6]);
                    string endereco = MyStringConvert(reader[7]);
                    int numEnd = MyIntonverter(reader[8]);
                    string complemento = MyStringConvert(reader[9]);
                    string bairro = MyStringConvert(reader[10]);
                    string cidade = MyStringConvert(reader[11]);
                    string estado = MyStringConvert(reader[12]);
                    //Testando dados testados do banco


                    

                    if (nivel.Equals(2))
                    {
                        //Cliente
                        
                        
                        
                        FrmPerfil telaPerfil = new FrmPerfil();

                        
                        telaPerfil.txtNome.Text = nome;
                        telaPerfil.txtEndereco.Text = endereco;
                        telaPerfil.txtCidade.Text = cidade;
                        telaPerfil.txtEstado.Text = estado;
                        telaPerfil.txtComplemento.Text = complemento;
                        telaPerfil.txtEmail.Text = email;
                        telaPerfil.txtCPF.Text = cpf.ToString();
                        telaPerfil.txtCEP.Text = cep;
                        telaPerfil.txtBairro.Text = bairro;
                        telaPerfil.txtNum.Text = numEnd.ToString();
                        telaPerfil.txtSenha.Text = senha;







                        TelaHome telaMenu = new TelaHome();
                        telaMenu.Show();

                        telaLogin.Hide();

                        return true;

                    }
                    else if (nivel.Equals(1))
                    {

                        return true;
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

                    window.TelaMessageBox telaMessageBox = new window.TelaMessageBox();
                    telaMessageBox.Mensagem("Email ou senha Incorretos!");
                    telaMessageBox.ShowDialog();

                    Helpers limparTela = new Helpers();



                    FrmMenu tela = new FrmMenu();
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



        public void AtualizarCliente(int clienteID, string novoNome, string novoEmail)
        {
            try
            {
                string sql = "UPDATE tb_clientes SET nome_cliente=@novoNome, email_cliente=@novoEmail WHERE id=@clienteId";
                MySqlCommand executacmd = new MySqlCommand(sql, conexao);
                executacmd.Parameters.AddWithValue("@novoNome", novoNome);
                executacmd.Parameters.AddWithValue("@novoEmail", novoEmail);
                executacmd.Parameters.AddWithValue("@clienteId", clienteID);

                conexao.Open();
                int rowsAffected = executacmd.ExecuteNonQuery();

                if (rowsAffected > 0)
                {

                }
                else
                {
 
                }

                conexao.Close();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao atualizar o cliente: " + erro.Message);
            }
        }



    }
}
