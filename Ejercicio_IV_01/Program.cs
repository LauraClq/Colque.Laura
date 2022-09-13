using System;
using BibliotecaSumador;

namespace Ejercicio_IV_01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Sumador";

            #region objeto Uno
            Sumador sumaUno = new Sumador();

            Console.WriteLine("Objeto sumaUno");
            Console.WriteLine($"La suma es: {sumaUno.Sumar(5,4)}");
            Console.WriteLine($"Concatenar: {sumaUno.Sumar("Hola ", "Mundo")}");
            Console.WriteLine($"Sumador: {sumaUno.Cantidad()}\n");
            #endregion

            #region objeto Dos
            Sumador sumaDos = new Sumador(7);
            Console.WriteLine("Objeto sumaDos");
            Console.WriteLine($"La suma es: {sumaDos.Sumar(3, 3)}");
            Console.WriteLine($"Concatenar: {sumaDos.Sumar("Asi estan ", "las cosas pais")}");
            Console.WriteLine($"Sumador: {sumaDos.Cantidad()}\n");
            #endregion

            Console.WriteLine($"Suma de objetos {(int)sumaUno} + {(int)sumaDos} = {sumaUno+sumaDos}");
            //casteo los objetos si no mostrria por consola BibliotecaSumador.Sumador + BibliotecaSumador.Sumador

            if(sumaUno | sumaDos)
            {
                Console.WriteLine("La comparacion es true");
            }
            else
            {
                Console.WriteLine("La comparacion es false");
            }

            Console.ReadLine();
        }
    }
}
