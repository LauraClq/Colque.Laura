using System;

namespace Ejercicio_05
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero;
            int acumuladorInferiores;
            int acumuladorSuperiores;
            string esNumero;

            Console.Title = "Tirame un centro";

            do
            {
                Console.Write("Ingrese un numero: ");
                esNumero = Console.ReadLine();

            } while (!int.TryParse(esNumero, out numero));



            for (int centro = 1; centro < numero; centro++) // Este for recorre desde 1 hasta el numero ingresado
            {
                acumuladorInferiores = 0;

                for (int inferior = 0; inferior < centro; inferior++) //Este for recorre desde 1 hasta el centro, sin contar el mismo centro
                {
                    acumuladorInferiores += inferior;
                }

                acumuladorSuperiores = 0;

                for (int superior = centro + 1; superior <= acumuladorInferiores; superior++) // Este for recorre un paso mas que el centro, asi no lo cuenta y tiene que ser >= al inferior
                {
                    if ((acumuladorInferiores == acumuladorSuperiores) || (acumuladorSuperiores > acumuladorInferiores))
                    {
                        break;
                    }

                    acumuladorSuperiores += superior;
                }

                if (acumuladorInferiores == acumuladorSuperiores)
                {
                    Console.WriteLine("{0} es un numero central.", centro);
                }
            }
            Console.ReadLine();

        }

    }
}
