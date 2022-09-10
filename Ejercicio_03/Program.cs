using System;

namespace Ejercicio_03
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero = 0;
            string esNumero;
            int contador;
            string confimra;

            do
            {
                Console.Write("Ingrese un numero o la palabra salir: ");
                esNumero = Console.ReadLine();

            } while (esNumero != "salir" && !int.TryParse(esNumero, out numero)); //si esNumero es verdadero, el tryParse es false pero lo convierto en true

            for (int i = 2; i <= numero; i++)
            {
                contador = 0; //cada vez que vaya al siguiente numero se inicializa en 0

                for (int j = 1; j <= numero; j++)
                {
                    if( i % j == 0)
                    {
                        contador++; //se incrementa si el numero es compuesto, es decir mas de dos divisores
                    }
                }

                if (contador == 2) //es un numero primo porque solo tiene solo 2 divisores, el 1 y el mismo.
                {
                    Console.WriteLine("{0} es un numero primo.", i);
                    //Es decir solo dos veces el modulo fue 0. No conto mas divisores.

                }

            }

            Console.Write("Desea nuevamente iterar? Ingrese si o no: ");
            confimra = Console.ReadLine();

            if (confimra == "si")
            {
                Main(args);
            }
            

        }
    }
}
