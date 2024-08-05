using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TESTE_GUNA.projeto.model
{
    public class Venda
    {
        public int cliente_id { get; set; }
        public decimal total_venda { get; set; }
        public int id_pagamento { get; set; }
        public string tipo_pag { get; set; }

        public string num_cartao { get; set; }

        public string mes { get; set; }
        public string ano { get; set; }
        public string cvv { get; set; }
    }
}
