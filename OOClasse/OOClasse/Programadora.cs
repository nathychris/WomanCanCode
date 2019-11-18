using System;
using System.Collections.Generic;
using System.Text;

namespace OOClasse
{
    class Programadora : Pessoa
    {
       public Programadora(int anosDeCarreira, bool possuiGraduacao)
        {
            Linguagens = new List<string>();

            PossuiGraduacao = possuiGraduacao;
            AnosDeCarreira = anosDeCarreira;


        }
        public List<string> Linguagens { get; set; }
        public int AnosDeCarreira { get; set; }
        public bool PossuiGraduacao { get; set; }
        public bool TrabalhaNaArea { get; set; }
        public decimal Salario { get; set; }
    }
}
