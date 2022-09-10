using System;

namespace Ejercicio_01
{
    class Program
    {
        static void Main(string[] args)
        {
            int numeros = 0;
            int minimo = 0;
            int mayor = 0;
            int acumulador = 0;
            float promedio = 0;
            int flag = 1;

            for (int i = 0; i < 5; i++)
            {
                Console.Write("Ingrese un numero: ");
                numeros = int.Parse(Console.ReadLine());

                if(flag == 1)
                {
                    mayor = numeros;
                    minimo = numeros;
                    flag = 0;
                }
                else if(numeros > mayor)
                {
                    mayor = numeros;
                }
                else if(numeros < minimo)
                {
                    minimo = numeros;
                }

                acumulador += numeros;
            }

            promedio = (float) acumulador / 5;

            Console.WriteLine("\nEl numero mayor es: {0}\n El minimo es: {1}\n El promedio es: {2}",mayor,minimo,promedio);
            Console.ReadLine();

        }
    }
}
