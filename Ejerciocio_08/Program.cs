using System;

namespace Ejerciocio_08
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.Title = "Tiangulo Rectangulo";

            int altura;
            int incremento = 0;
            int dibujo;
            string esNumero;
            string triangulo = "*";
            string espacio = "";

            do
            {
                Console.Write("Ingrese la medidad para el triangulo rectangulo: ");
                esNumero = Console.ReadLine();

            } while (!int.TryParse(esNumero, out altura));

            dibujo = altura;

            while (incremento < altura) 
            {
                incremento++;

                for (int i = 0; i < dibujo; i++)
                {
                    espacio += "";
                }

                dibujo--;
                Console.WriteLine("{0}",triangulo);
                triangulo = "*" + triangulo + "*";
            }
            Console.ReadLine();

        
        }
    }
}
