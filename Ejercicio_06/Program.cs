using System;

namespace Ejercicio_06
{
    class Program
    {
        static void Main(string[] args)
        {
            string esNumeroInicio;
            string esNumeroFin;
            int anioInicio;
            int anioFin;

            Console.Title = "Anios bisiestos";
            do
            {
                Console.Write("Ingrese el anio de inicio: ");
                esNumeroInicio = Console.ReadLine();

            } while (!int.TryParse(esNumeroInicio, out anioInicio));           
            
            do
            {
                Console.Write("Ingrese el anio de fin: ");
                esNumeroFin = Console.ReadLine();

            } while (!int.TryParse(esNumeroFin, out anioFin));

            for (int i = anioInicio; i <= anioFin; i++)
            {
                if ( (i % 4 == 0 && i % 100 != 0) || (i % 400 == 0))
                {
                    Console.WriteLine("El anio {0} es bisiesto",i);
                    
                }
                else
                {
                    Console.WriteLine("El anio {0} no es bisiesto",i);
                }
               
            }

            Console.ReadLine();


        }
    }
}
