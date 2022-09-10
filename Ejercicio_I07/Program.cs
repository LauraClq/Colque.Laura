using System;

namespace Ejercicio_I07
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Pitagoras estaria orgulloso";

            double baseTriangulo;
            double alturaTriangulo;
            double resultado;

            Console.Write("Ingrese la base del triangulo para calcular la hipotenusa: ");
            baseTriangulo = double.Parse(Console.ReadLine());

            Console.Write("Ingrese la altura del triangulo para calcular la hipotenusa: ");
            alturaTriangulo = double.Parse(Console.ReadLine());

            resultado = Math.Sqrt(Math.Pow(baseTriangulo, 2) + Math.Pow(alturaTriangulo, 2));

            Console.WriteLine($"La hipotenusa es: {resultado}");

        }
    }
}
