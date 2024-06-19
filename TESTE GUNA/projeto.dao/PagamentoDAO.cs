using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TESTE_GUNA.projet.conexao;

namespace TESTE_GUNA.projeto.dao
{
    internal class PagamentoDAO
    {

        //Conecta com o Banco de dados
        private MySqlConnection conexao;


        //Construtor
        public PagamentoDAO()
        {
            this.conexao = new ConnectionFactory().getconnection();

        }




    }
}
