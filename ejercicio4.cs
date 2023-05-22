using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*
 * Crea una única función (importante que sólo sea una) que sea capaz
 * de calcular y retornar el área de un polígono.
 * - La función recibirá por parámetro sólo UN polígono a la vez.
 * - Los polígonos soportados serán Triángulo, Cuadrado y Rectángulo.
 * - Imprime el cálculo del área de un polígono de cada tipo.
 */

namespace AreaDeUnPoligono
{

    class Program
    {
        static void Main(string[] args)
        {
            // Ejemplos de uso de la función
            Console.WriteLine("Área del triángulo: " + CalcularAreaTriangulo(5, 3));
            Console.WriteLine("Área del cuadrado: " + CalcularAreaCuadrado(4));
            Console.WriteLine("Área del rectángulo: " + CalcularAreaRectangulo(6, 2));
            Console.ReadLine();
        }

        static double CalcularAreaTriangulo(double baseTriangulo, double alturaTriangulo)
        {
            double areaTriangulo = (baseTriangulo * alturaTriangulo) / 2;
            return areaTriangulo;
        }

        static double CalcularAreaCuadrado(double ladoCuadrado)
        {
            double areaCuadrado = ladoCuadrado * ladoCuadrado;
            return areaCuadrado;
        }

        static double CalcularAreaRectangulo(double baseRectangulo, double alturaRectangulo)
        {
            double areaRectangulo = baseRectangulo * alturaRectangulo;
            return areaRectangulo;
        }
    }
}
