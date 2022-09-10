using System;

namespace Ejercicio_I04
{
    class Program
    {
        static void Main(string[] args)
        {
            string confirma;
            int primerNumero;
            int segundoNumero;
            char operador;
            float resultado;

            do
            {
                Console.Write("Ingrese el primer operando: ");
                primerNumero = int.Parse(Console.ReadLine());

                Console.Write("Ingrese el segundo operando: ");
                segundoNumero = int.Parse(Console.ReadLine());

                Console.Write("Ingrese el operandor + , - , / , * : ");
                operador = Console.ReadKey(true).KeyChar;

            } while (primerNumero < 0 && segundoNumero < 0);

            resultado = Calculadora.Calcular(primerNumero, segundoNumero, operador);

            if (resultado == -1)
            {
                Console.WriteLine("No se puede dividir un numero por 0.");
            }
            else if(resultado == -2)
            {
                Console.WriteLine("Operador incorrecto");
            }
            else
            {
                Console.WriteLine($"\n{primerNumero} {operador} {segundoNumero} = {resultado}");
            }
            

            Console.Write("Desea seguir? Ingrese si o no: ");
            confirma = Console.ReadLine();

            if (confirma == "si")
            {
                Main(args);
            }
        }
    }
}
