using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EscolaDeProgramcao.Models
{
    public class Pessoa
    {
        public int Nome { get; set; }
        public DateTime DatadeNascimento { get; set; }
        public int CPF { get; set; }
        public string Email { get; set; }
        public Endereco MeuEndereco { get; set; }
    }
}
