using System;
using Petshop;

namespace BricandodeCodar
{
    class Program
    {


        static void Main(string[] args)
        {
            Veterinario drPet = new Veterinario();
            DadosPessoais();
            DadosParaPagamento();

            //List<string> especialidade,
            //List< DateTime > diadeAtendimento,
        }

        private static void DadosPessoais()
        {
            Console.WriteLine("Informe o nome do Veterinario");
            string nome = Console.ReadLine();

            Console.WriteLine("Informe o CRMV do Veterinario");
            string crmv = Console.ReadLine();

            Console.WriteLine("Informe o Crachá do Veterinario");
            string cracha = Console.ReadLine();
        }

        private static void DadosParaPagamento()
        {
            Console.WriteLine("Informe o Salario do Veterinario");
            decimal salario = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Informe o Banco para pagamento do Veterinario");
            string banco = Console.ReadLine();

            Console.WriteLine("Informe o Agência para pagamento do do Veterinario");
            string agencia = Console.ReadLine();

            Console.WriteLine("Informe o conta corrente para pagamento do do Veterinario");
            string cc = Console.ReadLine();
        }
        
    }
}
