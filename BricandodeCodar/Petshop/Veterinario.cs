using System;
using System.Collections.Generic;
using System.Text;

namespace Petshop
{
    public class Veterinario : Funcionario
    {
        public Veterinario()
        {
            Especialidade = new List<string>();
            DiaDeAtendimento = new List<DateTime>();
        }

        public string CRMV { get; set; }
        public List<string> Especialidade { get; set; }
        public List<DateTime> DiaDeAtendimento { get; set; }


        public void Incluir(string crmv,
            List<string> especialidade,
            List<DateTime> diadeAtendimento,
            decimal salario,
            string codigoCracha,
            string banco,
            string contaCorrente,
            string agencia)
        {
            AdmitirFuncionario(salario, codigoCracha, banco, contaCorrente, agencia);
            CRMV = crmv;
            Especialidade = especialidade;
            DiaDeAtendimento = diadeAtendimento;
        }
    }
}
