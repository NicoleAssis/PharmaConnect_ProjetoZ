using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TESTE_GUNA.projeto.model
{
    class CarrinhoB
    {
        public int id_produtoCarrinho { get; set; }
        public string nome_produtoCarrinho { get; set; }
        public string desc_produtoCarrinho { get; set; }
        public decimal preco_produtoCarrinho { get; set; }
        public int qtd_Carrinho { get; set; }
        public decimal subtotalCarrinho { get; set; }
        public decimal totalCarrinho { get; set; }

        public string departamento { get; set; }

    }
}
