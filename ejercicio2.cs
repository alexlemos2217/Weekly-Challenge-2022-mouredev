using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*
 * Escribe un programa que imprima los 50 primeros números de la sucesión
 * de Fibonacci empezando en 0.
 * - La serie Fibonacci se compone por una sucesión de números en
 *   la que el siguiente siempre es la suma de los dos anteriores.
 *   0, 1, 1, 2, 3, 5, 8, 13...
 */

namespace ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            long n1 = 0;
            long n2 = 1;

            for (int i = 1; i <= 50; i++)
            {
                Console.WriteLine(n1);

                long fib = n1 + n2;
                n1 = n2;
                n2 = fib;
            }

            Console.ReadLine();
        }
    }
}
