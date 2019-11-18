using System;
using System.Collections.Generic;
using System.Text;

namespace Crush
{
    class Comportamento
    {
        public string Descricao { get; set; }
        public int Intensidade { get; set; }

        public void IncluirIntesidade(int intensidade)
        {
            Intensidade += intensidade;
        }

        public void DiminuirIntesidade(int intensidade)
        {
            Intensidade -= intensidade;
        }
    }
}
