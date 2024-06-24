using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TESTE_GUNA.projet.conexao;

namespace TESTE_GUNA.projeto.dao
{
    public class DepartamentoDAO
    {

        //Conecta com o Banco de dados
        private MySqlConnection conexao;


        //Construtor
        public DepartamentoDAO()
        {
            this.conexao = new ConnectionFactory().getconnection();

        }



        public DataTable ListarProdutosPorDepartamento(string departamento)
        {
            try
            {
                // Criar DataTable e comando SQL
                DataTable tabelaProdutos = new DataTable();

                // Consulta SQL com parâmetro para o departamento
                string sql = @"
            SELECT  
                id_produto AS 'ID Produto',
                nome_produto AS 'Nome Produto',
                desc_produto AS 'Descrição',
                preco_produto AS 'Preço',
                qtd_estoque AS 'Qtd Estoque',
                departamento AS 'Departamento'
            FROM 
                tb_produto
            WHERE 
                departamento = @departamento;
        ";

                // Organizar o comando e executar
                MySqlCommand cmd = new MySqlCommand(sql, conexao);
                cmd.Parameters.AddWithValue("@departamento", departamento);

                // Abrir conexão e executar o comando
                conexao.Open();
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                da.Fill(tabelaProdutos);
                conexao.Close();

                return tabelaProdutos;
            }
            catch (Exception erro)
            {
                //MessageBox.Show("Erro ao listar produtos por departamento: " + erro.Message);
                return null;
            }
        }










    }
}
