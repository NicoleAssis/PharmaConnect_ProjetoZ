using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TESTE_GUNA.projeto.model
{
    public class Venda
    {
        public int data_venda { get; set; }
        public int id_cliente { get; set; }
        public int forma_pagamento { get; set; }
        public int valor_total { get; set; }
    }
}
