using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EscolaDeProgramcao.Models
{
    public class Turma
    {
        public string Codigo { get; set; }
        public Turno TurnoDeAula { get; set; }
        public List<Materia> MinhasMateria { get; set; }
        public Professor ProfessorDaTurma { get; set; }
        public List<Aluno> TodosOsAlunos { get; set; }
    }
}
