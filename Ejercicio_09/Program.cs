using System;

namespace Ejercicio_09
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Triangulo Equilatero";

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

                for (int i = 0; i < dibujo; i++) // 0 < 5; va a seguir hasta completar 5 vueltas 
                {
                    espacio += " ";
                    // 0 < 4; completa 4 vueltas triangulo = * + **      2 ciclo
                    // 0 < 3; comlpleta 3 vueltas triangulo = *** + **   3 ciclo
                    // 0 < 2; completa 2 vueltas triangulo = ***** + **  4 ciclo
                    // 0 < 1; completa 1 vuelta triangulo = ******* + ** 5 ciclo
                }

                dibujo--; //cada decremento el espacio se va reduciendo
                Console.WriteLine("{1}{0}", triangulo, espacio); // 1 ciclo
                triangulo = "*" + triangulo + "*"; //solo en el segundo ciclo triangulo = * mas  * * agregados
                espacio = ""; // aca reseteo el espacio
            }
            Console.ReadLine();
        }
    }
}

