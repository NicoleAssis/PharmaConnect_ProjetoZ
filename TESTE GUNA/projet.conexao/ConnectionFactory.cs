using MySql.Data.MySqlClient;

using System.Configuration;


namespace TESTE_GUNA.projet.conexao
{
    public class ConnectionFactory
    {
        //metodo que conecta ao banco de dados

        public MySqlConnection getconnection()
        {
            string conexao = ConfigurationManager.ConnectionStrings["bdfarmacia"].ConnectionString;


            return new MySqlConnection(conexao);
        }

    }
}
