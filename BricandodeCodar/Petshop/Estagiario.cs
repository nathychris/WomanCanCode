using System;
using System.Collections.Generic;
using System.Text;

namespace Petshop
{
    public class Estagiario : Funcionario
    {
        public string Curso { get; set; }
        public TipoCurso TipoCurso { get; set; }
        public string TempoCurso { get; set; }
        public string TempoRestante { get; set; }
        public string AreaAtuacao { get; set; }
    }

    public enum TipoCurso
    {
        EnsinoFundamental,
        EnsinoMedio,
        Graduacao,
        PossuiGraduacao
    }
}
