using System;
using BibliotecaBoligrafo;

namespace Ejercicio_III04
{
    class Program
    {
        static void Main(string[] args)
        {
            string dibujo;
            bool todoBien;
            /*
            Boligrafo tintaAzul = new Boligrafo(100, ConsoleColor.Blue);

            Console.ForegroundColor = tintaAzul.GetColor(); // Lo pinto de azul
            tintaAzul.Recargar(); //Lo recargo a su nivel maximo
            
            Console.WriteLine($"{tintaAzul.GetColor()} {tintaAzul.GetTinta()}");

            todoBien = tintaAzul.Pintar(60, out dibujo);
            
            Console.WriteLine($"Dibujo: {dibujo}");
            Console.WriteLine($"Tinta: {tintaAzul.GetTinta()}");
            Console.WriteLine($"Retorno: {todoBien}");
            
            Console.ResetColor();
            */
            Boligrafo tintaRoja = new Boligrafo(50, ConsoleColor.Red);

            Console.ForegroundColor = tintaRoja.GetColor();
            tintaRoja.Recargar();

            Console.WriteLine($"{tintaRoja.GetColor()} {tintaRoja.GetTinta()}");
            
            todoBien = tintaRoja.Pintar(60, out dibujo);

            Console.WriteLine($"Dibujo: {dibujo}");
            Console.WriteLine($"Tinta: {tintaRoja.GetTinta()}");
            Console.WriteLine($"Retorno: {todoBien}");


            Console.ReadLine();
        }
    }
}
