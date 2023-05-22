using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InvirtiendoCadenas
{

    using System;

    class Program
    {
        static void Main()
        {
            // Solicitar al usuario que ingrese una cadena de texto
            Console.Write("Ingrese una cadena de texto: ");
            string texto = Console.ReadLine();

            // Llamar a la función Reverse para obtener el texto invertido
            string textoInvertido = Reverse(texto);

            // Mostrar el texto invertido en la consola
            Console.WriteLine("Texto invertido: " + textoInvertido);
            Console.ReadLine();
        }

        static string Reverse(string text)
        {
            // Obtener la cantidad de caracteres en el texto
            int textCount = text.Length - 1;

            // Variable para almacenar el texto invertido
            string reversedText = "";

            // Recorrer el texto desde el primer caracter hasta el último
            for (int index = 0; index <= textCount; index++)
            {
                // Agregar el caracter correspondiente al texto invertido
                reversedText += text[textCount - index];
            }

            // Retornar el texto invertido
            return reversedText;
        }
    }

}
