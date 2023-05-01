using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*
 * Escribe un programa que muestre por consola (con un print) los
 * números de 1 a 100 (ambos incluidos y con un salto de línea entre
 * cada impresión), sustituyendo los siguientes:
 * - Múltiplos de 3 por la palabra "fizz".
 * - Múltiplos de 5 por la palabra "buzz".
 * - Múltiplos de 3 y de 5 a la vez por la palabra "fizzbuzz".
 */

namespace retosSemanales
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int index = 1; index <= 100; index++)
            {
                bool divisibleEntreTres = index % 3 == 0;
                bool divisibleEntreCinco = index % 5 == 0;
                if (divisibleEntreTres && divisibleEntreCinco)
                {
                    Console.WriteLine("fizzbuzz");
                }
                else if (divisibleEntreTres)
                {
                    Console.WriteLine("fizz");
                }
                else if (divisibleEntreCinco)
                {
                    Console.WriteLine("buzz");
                }
                else
                {
                    Console.WriteLine(index);
                }

            }

            Console.ReadLine();
        }
    }
}