using System;
using System.Text;
using BibliotecaGeometria;

namespace Ejercicio_III05
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Prueba de Geometria";

            Punto puntoUno = new Punto(4,6);
            Punto puntoDos = new Punto(2,5);

            Rectangulo rectanguloUno = new Rectangulo(puntoUno,puntoDos);
            Console.WriteLine(Mostrar(rectanguloUno));
           
        }

        static string Mostrar(Rectangulo rectangulo)
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Datos del Rectangulo:");
            sb.AppendLine($"El area: {rectangulo.Area()} El perimetro: {rectangulo.Perimetro()}");

            return sb.ToString();

        }
    }
}
