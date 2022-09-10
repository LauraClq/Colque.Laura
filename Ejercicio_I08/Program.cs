using System;

namespace Ejercicio_I08
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "El tiempo pasa...";

             DateTime fechaCumpleanio;
             string fechaActual = DateTime.Now.ToString("dd-MM-yyyy");
             bool resultado;
             int diasVividos;

             do
             {
                 Console.Write("Ingrese la fecha de su cumpleanios para calcular los dias vividos ej 05/05/2000: ");
                 resultado = DateTime.TryParse(Console.ReadLine(), out fechaCumpleanio);

             } while (!resultado);

             diasVividos = DiasVividos(fechaCumpleanio);

             static int DiasVividos(DateTime fecha)
             {
                 int numeroDias;
                 DateTime fechaActual = DateTime.Today;

                //string datoFecha = DateTime.Now.ToString("dd-MM-yyyy");
                //fechaActual = DateTime.Parse(datoFecha); //parseo la fecha de tipo string a DateTime


                TimeSpan fechaDiferencia = fechaActual - fecha;

                 numeroDias = fechaDiferencia.Days;

                 return numeroDias;
             }

             Console.WriteLine($"Son {diasVividos} dias vividos hasta la fecha actual {fechaActual}");

            Console.ReadLine();

        }
    }
}


