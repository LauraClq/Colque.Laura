using System;

namespace Ejercicio_02
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero = 0;
            int cuadrado = 0;
            int cubo = 0;

            Console.Write("Ingrese un numero: ");
            numero = int.Parse(Console.ReadLine());

            do
            {
                Console.Write("ERROR, Reingresar el numero mayor o igual 0: ");
                numero = int.Parse(Console.ReadLine());

            } while (numero <= 0);

            cuadrado = (int) Math.Pow(numero, 2);
            cubo = (int) Math.Pow(numero, 3);

            Console.WriteLine("\nEl numero: {0} al cuadrado es: {1} y al cubo es: {2}", numero, cuadrado, cubo);
            Console.ReadLine();
        }
    }
}
