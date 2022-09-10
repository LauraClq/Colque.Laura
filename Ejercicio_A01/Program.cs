using System;

namespace Ejercicio_A01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Calcular un factorial";
            int numero;
            long resultado;

            do
            {
                Console.Write("Ingrese un numero entero positivo: ");
                numero = int.Parse(Console.ReadLine());

            } while (numero < 0);

            resultado = Factorial(numero);

            static long Factorial(int numeroEntero)
            {
                long factorial = 1;

                for (int i = 1; i <= numeroEntero; i++)
                {
                    factorial *= i;
                }

                return factorial;
            }

            Console.WriteLine($"El factorial del numero {numero} es {resultado}");
            Console.ReadLine();
            
        }
    }
}
