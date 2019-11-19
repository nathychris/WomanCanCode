using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EscolaDeProgramcao.Models
{
    public class Notas
    {
        public string CodigoTurma { get; set; }
        public decimal Nota1 { get; set; }
        public decimal Nota2 { get; set; }
        public decimal Nota3 { get; set; }

        public bool Aprovado
        {
            get
            {
                decimal somaNotas = Nota1 + Nota2 + Nota3;
                return somaNotas == 0 ? false : somaNotas / 3 >= 6;
                
                   
            }
            
        }
    }
}
