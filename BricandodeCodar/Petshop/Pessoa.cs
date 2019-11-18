using System;
using System.Collections.Generic;
using System.Text;

namespace Petshop
{
    public abstract class Pessoa
    {
        public Pessoa()
        {
            MeuEndereco = new Endereco();
        }


        public int id { get; set; }
        public string Nome { get; set; }
        public DateTime DatadeNascimento { get; set; }
        public string Telefone { get; set; }
        public string CPF { get; set; }
        public string Email { get; set; }
        public Endereco MeuEndereco { get; set; }


        public int Idade
        {
            get
            {
                //string sobrenome = "Gameiro";
                //Operador Ternario
                //string nome  = sobrenome == "Gameiro" ? "Thamirys" : "Não Conheço";//
                

                int idade =  DateTime.Today.Year - DatadeNascimento.Year;
                return DatadeNascimento.AddYears(idade) > DateTime.Today
                ? idade-- : idade;

            }

           
        }
    }
}
