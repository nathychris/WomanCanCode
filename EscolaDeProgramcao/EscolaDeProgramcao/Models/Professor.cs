using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EscolaDeProgramcao.Models
{
    public class Professor : Pessoa
    {
        public Graduacao MinhaGraduacao { get; set; }
        public List<Materia> TiposAulas { get; set; }
        public decimal Salario { get; set; }
        public List<Turno> TurnoDisponiveis { get; set; }
    }
}
