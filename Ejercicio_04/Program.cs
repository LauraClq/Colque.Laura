using System;

namespace Ejercicio_04
{
    class Program
    {
        static void Main(string[] args)
        {
            int contador = 0;
            int acumulador;
            int i = 1;

            Console.Title = "Un numero perfecto";
           
            Console.WriteLine("Los cuatro numeros perfectos son: ");

            while (contador <  4)
            {
                acumulador = 0; 

                for (int j = 1; j < i ; j++) // j < i -->  1 < 6 - 2 < 6 ... 6 < 6 termina el bucle, porque excluye el mismo, j <= i con el igual NO lo excluyo
                {
                    if (i % j == 0)
                    {
                        acumulador += j; // acumulo los divisores
                    }
                }

                if (acumulador == i) // compararo si el numero es igual a lo que sumo el acumuldor
                {
                    Console.WriteLine(i); // Muestra el numero perfecto
                    contador++; //incremnta el contador se encontro un numero perfecto
                }

                i++; //pasa al siguiente numero a validar

            }
            
        }
    }
}
