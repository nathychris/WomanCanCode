using System;
using System.Collections.Generic;
using System.Text;

namespace Crush
{
    class Crush
    {
        public string Apelido { get; set; }
        public string Telefone { get; set; }
        public string Local { get; set; }
        public EstadoCivil EstadoCivilCrush { get; set; }
        public int Avaliacao { get; set; }
        public List<Comportamento> Comportamento { get; set; }

    }

    public  enum EstadoCivil
    {
        Solteiro,
        Namorando,
        Casado,
        Divorciado,
        Viuvo,
        Noivo

    }
}
