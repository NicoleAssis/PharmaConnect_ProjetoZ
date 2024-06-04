using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TESTE_GUNA.projeto.model
{
    public class Produto
    {
        public string nome_produto { get; set; }
        public string desc_produto { get; set; }
        public int preco_produto { get; set; }
        public int qtd_estoque { get; set; }
        public int id_fornecedor { get; set; }

    }
}
