using System;
using Bibiblioteca;

namespace Ejercicio_III03
{
    class Program
    {
        static void Main(string[] args)
        {
            Estudiante alumnoUno = new Estudiante("Maria","Lopez","1234");
            Estudiante alumnoDos = new Estudiante("Laura","Colque","1849");
            Estudiante alumnoTres = new Estudiante("Sofia","Perez","8930");

            alumnoUno.SetNotaPrimerParcial(8);
            alumnoUno.SetNotaSegundoParcial(7);
            Console.WriteLine(alumnoUno.Mostrar());

            alumnoDos.SetNotaPrimerParcial(8);
            alumnoDos.SetNotaSegundoParcial(9);
            Console.WriteLine(alumnoDos.Mostrar()) ;

            alumnoTres.SetNotaPrimerParcial(3);
            alumnoTres.SetNotaSegundoParcial(2);
            Console.WriteLine(alumnoTres.Mostrar());

            Console.ReadLine();

        }
    }
}
