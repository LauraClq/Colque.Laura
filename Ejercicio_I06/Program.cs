using System;

namespace Ejercicio_I06
{
    class Program
    {
        static void Main(string[] args)
        {
            double numeroCuadrado;
            double resultadoCuadrado;

            double baseTriangulo;
            double alturaTriangulo;
            double resultadoTriangulo;

            double numeroRadio;
            double resultadoRadio;

            Console.Write("Ingrese el numero a calcular del area del cuadrado: ");
            numeroCuadrado = double.Parse(Console.ReadLine());

            resultadoCuadrado = CalculadoraDeArea.CalcularAreaCuadrado(numeroCuadrado);

            Console.WriteLine($"El area del cuadrado de {numeroCuadrado} es {resultadoCuadrado}");


            Console.Write("Ingrese la base area del triangulo: ");
            baseTriangulo = double.Parse(Console.ReadLine());

            Console.Write("Ingrese la altura area del triangulo: ");
            alturaTriangulo = double.Parse(Console.ReadLine());

            resultadoTriangulo = CalculadoraDeArea.CalcularAreaTriangulo(baseTriangulo, alturaTriangulo);

            Console.WriteLine($"El area del triangulo es {resultadoTriangulo}");


            Console.Write("Ingrese el radio del area del circulo: ");
            numeroRadio = double.Parse(Console.ReadLine());

            resultadoRadio = CalculadoraDeArea.CalcularAreaCirculo(numeroRadio);

            Console.WriteLine($"El area del circulo es {resultadoRadio}");

            Console.ReadLine();
        }
    }
}
