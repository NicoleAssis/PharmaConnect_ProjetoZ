﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TESTE_GUNA.projeto.model
{
    public class ItemVenda
    {
        public int venda_id { get; set; }
        public int produto_id { get; set; }
        public int quantidade { get; set; }
        public int subtotal { get; set; }

    }
}