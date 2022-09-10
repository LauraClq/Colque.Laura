using System;
using BibliotecaCuenta;

namespace Ejercicio_III01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Creo que necesito un prestamo";

            Cuenta saldo = new Cuenta();

            Console.WriteLine($"Titular: {saldo.GetTitular()} Cantiadad en la cuenta: {saldo.GetCantidad()}\n");

            saldo.Ingresar(14500.15);

            Console.WriteLine(saldo.Mostrar());

            saldo.Retirar(10000);

            Console.WriteLine(saldo.Mostrar());

            Console.ReadLine();
        }
    }
}
