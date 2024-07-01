using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TESTE_GUNA.projeto.model
{
    public class FormaPagamento
    {
        public string tipoPagamento { get; set; }
        public string numCartao { get; set; }
        public string mes { get; set; }
        public string ano { get; set; }
        public string cvv { get; set; }
        public int idCliente { get; set; }

    }
}
