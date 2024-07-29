using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TESTE_GUNA.projeto.model
{
    public class Produto
    {
        public int Id_Produto { get; set; }
        public string nomeProduto { get; set; }
        public string descProduto { get; set; }
        public decimal precoProduto { get; set; }
        public int qtdEstoque { get; set; }
        public string departamento { get; set; }       

    }
}
