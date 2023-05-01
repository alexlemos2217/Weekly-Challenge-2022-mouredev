using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*
 * Escribe una función que reciba dos palabras (String) y retorne
 * verdadero o falso (Bool) según sean o no anagramas.
 * - Un Anagrama consiste en formar una palabra reordenando TODAS
 *   las letras de otra palabra inicial.
 * - NO hace falta comprobar que ambas palabras existan.
 * - Dos palabras exactamente iguales no son anagrama.
 */

using System;
using System.Linq;

namespace ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(esAnagrama("llenaba", "ballena"));
            Console.ReadLine();
        }

        static bool esAnagrama(string palabraUno, string palabraDos)
        {
            if (palabraUno.ToLower() == palabraDos.ToLower())
            {
                return false;
            }
            return palabraUno.ToLower().ToCharArray().OrderBy(c => c).SequenceEqual(palabraDos.ToLower().ToCharArray().OrderBy(c => c));

        }
    }
}
