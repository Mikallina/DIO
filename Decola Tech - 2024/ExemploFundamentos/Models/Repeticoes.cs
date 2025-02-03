using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploFundamentos.Models
{
    public class Repeticoes
    {
        public void ExecutarFor()
        {
            int contador = 5;

            for (int numero = 0; numero <= 5; numero++)
            {
                Console.WriteLine($"{numero} x {contador} = {numero * contador}");
            }
        }

        public void ExecutarWhile()
        {
            int numero = 5;
            int contador = 1;
            while (contador <= 10)
            {
                Console.WriteLine($"{numero} x {contador} = {numero * contador}");
                contador++;
            }
        }

        public void ExecutarDoWhile()
        {
            int numero = 0;
            int soma = 0;
            do
            {
                Console.WriteLine("Digite um numero, caso queira parar digite 0");
                numero = Convert.ToInt32(Console.ReadLine());
                soma += numero;
            }
            while (numero != 0);
            Console.WriteLine($"O Total dos numeros digitados é: {soma}");
        }


        public void Menu()
        {
            string opcao;
            bool exibirMenu = true;

            while(exibirMenu)
            {
               // Console.Clear();
                Console.WriteLine("Digite sua opção:");
                Console.WriteLine("1 - Cadastrar Cliente");
                Console.WriteLine("2 - Buscar Cliente");
                Console.WriteLine("3 - Deletar Cliente");
                Console.WriteLine("4 - Encerrar Sistema");

                opcao = Console.ReadLine();
                switch (opcao)
                {
                    case "1":
                       Console.WriteLine("Cadastro de cliente");
                        break;
                    case "2":
                        Console.WriteLine("Buscar cliente");
                        break;
                    case "3":
                        Console.WriteLine("Deletar cliente");
                        break;
                    case "4":
                        Console.WriteLine("Encerrar Sistema");
                        exibirMenu = false;
                        break;
                    default:
                        Console.WriteLine("Opção Inválida");
                        break;
                }

                Console.WriteLine("Sistema Encerrou");
            }


        }
    }
}