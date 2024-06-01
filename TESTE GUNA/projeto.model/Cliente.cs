using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TESTE_GUNA.projeto.model
{
    public class Cliente
    {
        public int cpf_cnpj_cliente { get; set; }
        public string nome_cliente { get; set; }
        public string email_cliente { get; set; }
        public int telefone_cliente { get; set; }
        public string celular_cliente { get; set; }
        public string cep_cliente { get; set; }
        public string endereco_cliente { get; set; }
        public string numero_cliente { get; set; }
        public string complemento_cliente { get; set; }
        public string bairro_cliente { get; set; }
        public string cidade_cliente { get; set; }
        public string estado_cliente { get; set; }
        public string senha_cliente { get; set; }
        public int nivel_acesso { get; set; }

    }
}
