using System;

namespace Ejercicio_I03
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Conversor Binario";
            
            
            string binario;
            int numeroDecimal;

            int numero;
            int numeroBase;
            bool respuesta = true;
            int numeroBinario;
            
            do
            {
                Console.Write("Ingrese un numero a convertir a binario: ");
                numero = int.Parse(Console.ReadLine());

            } while (numero <= 0);

            binario =  Conversor.ConvertirDecimalABinario(numero);

            Console.WriteLine($"El numero {numero} a binario es {binario}");

           
            Console.Write("Ingrese el numero binario a convertir a decimal: ");
            numero = int.Parse(Console.ReadLine());
            numeroBinario = numero;

            //verfica que sea binario
            while (numero > 0)
            {
                numeroBase = numero % 10;
                numero = numero / 10;

                if (numeroBase > 1)
                {
                    respuesta = false;
                    numero = 0;
                }
            }

            if (respuesta)
            {
                numeroDecimal = Conversor.ConvertirBinarioADecimal(numeroBinario);
                Console.WriteLine($"El binario {numeroBinario} a decimal es {numeroDecimal}");
            }
            else
            {
                Console.WriteLine("No es binario");
            }

            Console.ReadLine();
        }
    }
}
