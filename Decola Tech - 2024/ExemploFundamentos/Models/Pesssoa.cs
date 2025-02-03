using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploFundamentos.Models
{
    public class Pessoa
    {
        public string Nome { get; set; }

        public int Idade { get; set; }

        // Construtor da classe
        public Pessoa()
        {
            // Inicialize a propriedade 'Nome' com um valor não nulo
            Nome = "Nome Padrão"; // Substitua "Nome Padrão" pelo valor desejado
        }

        public void Apresentar()
        {
            Console
                .WriteLine($"Olá, meu nome é {Nome}, e tenho a idade {Idade}");
        }
    }
}
