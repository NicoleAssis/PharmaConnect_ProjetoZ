using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TESTE_GUNA.projeto.model
{
    public class CarrinhoB
    {
        public int id_carrinho { get; set; }
        public int id_produtoCarrinho { get; set; }
        public int qtd_Carrinho { get; set; }
        public decimal subtotalCarrinho { get; set; }
        public decimal totalCarrinho { get; set; }
        public int id_cliente { get; set; }

        public string NomeProduto { get; set; }


    }
}
