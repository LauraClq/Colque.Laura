using System;

namespace Ejercicio_I01
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero = 0;
            int valorMinimo = 0;
            int valorMaximo = 0;
            float promedio = 0;
            int acumulador = 0;
            bool esNumero;

            for (int i = 0; i < 10; i++)
            {
                Console.Write("Ingrese 10 numeros enteros: ");

                do
                {
                    Console.Write("Ingrese 10 numeros enteros: ");
                    esNumero = int.TryParse(Console.ReadLine(), out numero);

                } while (!esNumero || Validador.Validar(numero,-100,100) == false);

       
                    if (i == 0)
                    {
                        valorMaximo = numero;
                        valorMinimo = numero;
          
                    }
                    else if (numero > valorMaximo)
                    {
                        valorMaximo = numero;
                    }
                    else if (numero < valorMinimo)
                    {
                        valorMinimo = numero;
                    }

                    acumulador += numero;
            }
            promedio = (float) acumulador / 10;
            Console.WriteLine("El valor mayor ingresado es: {0}\n El valor minimo ingresado es: {1}\n El promedio es: {2}",valorMaximo,valorMinimo,promedio);
            Console.ReadLine();
            
        }
    }
}
