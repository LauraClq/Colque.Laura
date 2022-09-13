using System;
using BibliotecaConductor;

namespace Ejercicio_IVA01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Vienen con sistema de auto-navegación";

            #region Conductor 1
            int[] kmDiasConductor1 = {200,599,899,0,256,0,1000};
            Conductor conductor1 = new Conductor("Luis",kmDiasConductor1);
            #endregion

            #region Conductor 2
            int[] kmDiasConductor2 = { 80, 600, 900, 0, 244, 300, 330 };
            Conductor conductor2 = new Conductor("Tomas", kmDiasConductor2);
            #endregion

            #region Conductor 3
            int[] kmDiasConductor3 = { 80, 90, 120, 340, 700, 0, 330 };
            Conductor conductor3 = new Conductor("Marina", kmDiasConductor3);
            #endregion


            Conductor[] arrayConductores = {conductor1, conductor2, conductor3};

            foreach (Conductor unConductor in arrayConductores)
            {
                Console.WriteLine(unConductor.Mostrar());
            }

            Console.WriteLine($"El conductor que hizo más km en esa semana es: {Conductor.ConductorMasKmSemana(arrayConductores)}");
            Console.WriteLine($"El conductor que hizo más km el día 3 es: {Conductor.ConductorMasKmDia3(arrayConductores)}");
            Console.WriteLine($"El conductor que hizo más km el día 5 es: {Conductor.ConductorMasKmDia5(arrayConductores)}");
            Console.ReadLine();
        }
    }
}
