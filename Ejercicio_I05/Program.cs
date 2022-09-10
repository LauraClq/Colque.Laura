using System;
using System.Text;

namespace Ejercicio_I05
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Aprendete las tablas";

            int numero;

            do
            {
                Console.Write("Ingrese un numero que desee saber la tabla de multiplicar: ");
                numero = int.Parse(Console.ReadLine());

            } while (numero < 0);

            Console.WriteLine(TablaDeMultiplicacion(numero));

            static string TablaDeMultiplicacion(int numero)
            {
                StringBuilder sb = new StringBuilder();

                int resultado;

                sb.AppendLine($"\n Tabla de Multiplicar del numero {numero}:");

                for (int i = 0; i <= 10; i++)
                {
                    resultado = numero * i;

                    sb.AppendLine($"  {numero} x {i} = {resultado}");
                }
                return sb.ToString();
            }

            Console.ReadLine();
        }
    }
}
