using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EscolaDeProgramcao.Models
{
    public class Aluno : Pessoa
    {
        public List<Turma> Turmas { get; set; }
        public decimal Mensalidade { get; set; }
    }
}
