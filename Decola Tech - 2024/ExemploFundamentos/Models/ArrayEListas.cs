using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploFundamentos.Models
{
    public class ArrayEListas
    {
        List<string> listaString = new List<string>();

        public void addElemento(string elemento)
        {
            listaString.Add (elemento);
        }

        public void PrintList()
        {
            Console.WriteLine("Percorrendo a Lista com o FOR");
            for (int i = 0; i < listaString.Count; i++)
            {
                Console.WriteLine($"Posição nº {i} - {listaString[i]}");
            }

            Console.WriteLine("Percorrendo a Lista com FOREACH");
            int contadorFor = 0;
            foreach (var item in listaString)
            {
                Console.WriteLine($"Posição nº {contadorFor} - {item}");
            }
        }
    }
}
