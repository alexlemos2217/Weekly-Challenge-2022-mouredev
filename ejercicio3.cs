using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*
 * Escribe un programa que se encargue de comprobar si un número es o no primo.
 * Hecho esto, imprime los números primos entre 1 y 100.
 */

namespace esprimo
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero;

            Console.WriteLine("Verificar si un número es primo");
            Console.WriteLine("Ingrese un número: ");
            numero = Convert.ToInt32(Console.ReadLine());

            if (EsPrimo(numero))
            {
                Console.WriteLine("El número es primo.");
            }
            else
            {
                Console.WriteLine("El número no es primo.");
            }
            Console.ReadLine();
            Console.WriteLine("Números primos entre 1 y 100:");
            ImprimirNumerosPrimos();

            Console.ReadLine();
        }

        static bool EsPrimo(int numero)
        {
            if (numero < 2)
            {
                return false;
            }

            for (int i = 2; i < numero; i++)
            {
                if (numero % i == 0)
                {
                    return false;
                }
            }

            return true;
        }

        static void ImprimirNumerosPrimos()
        {
            for (int i = 1; i <= 100; i++)
            {
                if (EsPrimo(i))
                {
                    Console.Write(i + " ");
                }
            }
            Console.WriteLine();
        }
    }
}