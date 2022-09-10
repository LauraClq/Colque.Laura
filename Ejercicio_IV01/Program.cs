using System;
using BibliotecaCosa;

namespace Ejercicio_IV01
{
    class Program
    {
        static void Main(string[] args)
        {
            Cosa objeto = new Cosa();

            objeto.EstablecerValor(1);
            objeto.EstablecerValor("Hola");
            objeto.EstablecerValor(new DateTime(2000,09,01));

            Console.WriteLine(Cosa.Mostrar(objeto));

            

        }
    }
}
