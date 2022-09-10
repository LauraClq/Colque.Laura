using System;
using BibliotecaPersona;

namespace Ejercicio_III02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Vos cuantas privameras tenes?";

            #region Persona 1
            Persona objetoUno = new Persona();

            objetoUno.SetNombre("Valkiria");
            objetoUno.SetFechaDeNacimiento(new DateTime(2000,10,01));
            objetoUno.SetDNI(42920184);

            Console.WriteLine(objetoUno.Mostrar());
            Console.WriteLine(objetoUno.EsMayorDeEdad());
            #endregion

            #region Persona 2
            Persona objetoDos = new Persona();

            objetoDos.SetNombre("Laura");
            objetoDos.SetFechaDeNacimiento(new DateTime(1999,05,09));
            objetoDos.SetDNI(8909345);

            Console.WriteLine(objetoDos.Mostrar());
            Console.WriteLine(objetoDos.EsMayorDeEdad());
            #endregion

            #region Persona 3
            Persona objetoTres = new Persona();

            objetoTres.SetNombre("Juan");
            objetoTres.SetFechaDeNacimiento(new DateTime(2015, 12, 06));
            objetoTres.SetDNI(46780123);

            Console.WriteLine(objetoTres.Mostrar());
            Console.WriteLine(objetoTres.EsMayorDeEdad());
            #endregion

            Console.ReadLine();

        }
    }
}
