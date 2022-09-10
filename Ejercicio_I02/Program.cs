using System;

namespace Ejercicio_I02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Desea Continuar?";
            int sumar = 0;
            char respuesta;
            int i = 0;

            do
            {
                i++;
                sumar += i;

                Console.WriteLine("La suma hasta el momento {0}\n",sumar);
                Console.WriteLine("Desea continuar? (S/N): ");

                respuesta = Console.ReadKey().KeyChar; //para el ingreso de char

            } while (Validador.ValidarRespuesta(respuesta));

            Console.WriteLine("La suma total: {0}", sumar);
            Console.ReadLine();
        }
    }
}
