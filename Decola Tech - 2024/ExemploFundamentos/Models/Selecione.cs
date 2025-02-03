using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploFundamentos.Models
{
    public class Selecione
    {
        public void ExecutarMenu()
        {
            string opcao;
            bool exibirMenu = true;

            while (exibirMenu)
            {
                // Console.Clear();
                Console.WriteLine("Digite o Programa que deseja Selecionar: ");
                Console.WriteLine("1 - Cadastro");
                Console.WriteLine("2 - Calculadora");
                Console.WriteLine("3 - Repetições");
                Console.WriteLine("4 - Array e Listas");
                Console.WriteLine("5 - Propriedades Métodos e Contrutores");
                Console.WriteLine("9 - Encerrar Sistema");

                opcao = Console.ReadLine();
                switch (opcao)
                {
                    case "1":
                        Console.WriteLine("Cadastro de cliente");
                        Pessoa pessoa = new Pessoa();
                        pessoa.Nome = "Michelle";
                        pessoa.Idade = 39;
                        pessoa.Apresentar();
                        break;
                    case "2":
                        Console.WriteLine("Calculadora");

                        //Calculadora
                        Console.WriteLine("-----CALCULADORA-------");
                        Calculadora calc = new Calculadora();
                        calc.Somar(10, 2);
                        calc.Subtrair(10, 5);
                        calc.Multiplicar(5, 5);
                        calc.Dividir(20, 2);
                        calc.Potencia(3, 3);
                        calc.Seno(5);
                        calc.Tangente(10);
                        calc.Coseno(3);
                        calc.Incremento(2);
                        calc.RaizQuadrada(9);
                        break;
                    case "3":
                        Console.WriteLine("Estrutura de Repetição");

                        //Estrutura de Repetições
                        Console.WriteLine("------FOR-------");
                        Repeticoes execFor = new Repeticoes();
                        execFor.ExecutarFor();

                        Console.WriteLine("------WHILE-------");
                        Repeticoes execWhile = new Repeticoes();
                        execWhile.ExecutarWhile();

                        Console.WriteLine("------DO WHILE-------");
                        Repeticoes executarDoWhile = new Repeticoes();
                        executarDoWhile.ExecutarDoWhile();

                        Console.WriteLine("------Menu-------");
                        Repeticoes menu = new Repeticoes();
                        menu.Menu();
                        break;
                    case "4":
                        Console.WriteLine("--------- Listas ---------");
                        ArrayEListas listaString = new ArrayEListas();
                        listaString.addElemento("Maria");
                        listaString.addElemento("Joao");
                        listaString.addElemento("Ricardo");
                        listaString.addElemento("Raphael");
                        listaString.PrintList();
                        break;
                    case "5":
                        PessoaMet pessoaMet = new PessoaMet();
                        pessoaMet.Nome = "Michelle";
                        pessoaMet.Idade = 39;
                        pessoaMet.Apresentar();
                        break;
                    case "9":
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
