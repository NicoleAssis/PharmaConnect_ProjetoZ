using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TESTE_GUNA.projeto.model
{
    public class Administrador
    {
        public string cpf_cnpj_administrador { get; set; }
        public string nome_administrador { get; set; }

        public int email_administrador { get; set; }
        public int telefone_administrador { get; set; }
        public int celular_administrador { get; set; }
        public int cep_administrador { get; set; }
        public int endereco_administrador { get; set; }

        public int numero_administrador { get; set; }
        public int complemento_administrador { get; set; }
        public int bairro_administrador { get; set; }

        public int numero_adminicicidade_administrador  { get; set; }
        public int estado_administrador { get; set; }
        public int senha_administrador { get; set; }
        public int nivel_acesso_administrador { get; set; }
    }
}
