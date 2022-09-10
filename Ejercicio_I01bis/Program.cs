using System;

namespace Ejercicio_I01bis
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Sello.mensaje = "Hola Mundo"; //modifico el atributo de la clase Sello

            Console.WriteLine(Sello.Imprimir()); //Muestro por consola, el metodo Impormir de la clase Sello
            Sello.Borrar(); //Invoco al metodo Borrar de la clase Sello 
            Console.WriteLine(Sello.Imprimir());
            


            Sello.mensaje = "Hola Mundo C#";

            Sello.color = ConsoleColor.Red; //Defino el color al atributo color
            Sello.ImprimirEnColor(); //Pongo de color al mensaje, invocando al metodo ImprimirEnColor
            Console.WriteLine(Sello.Imprimir()); 
            */

            Sello.mensaje = "Hola Mundo";
            Sello.color = ConsoleColor.Red;
            Sello.ImprimirEnColor();
            Console.WriteLine(Sello.Imprimir());
        }
    }
}
