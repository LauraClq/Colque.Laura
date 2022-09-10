using System;
using BibliotecaTinta;

namespace Ejercicio_IV02bis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Pluma y Tinta ejemplo de operaciones";

            string infoObj1;
            string infoObj2;

            Tinta objTinta1 = new Tinta(ETipoTinta.ConBrillito, ConsoleColor.Red);
            Pluma objPluma1 = new Pluma("Bic",objTinta1,9);

            infoObj1 = objPluma1; //casteo implicito, mi metodo mostrar de la clase Pluma recibe un Objeto de tipo Pluma 
            //y lo "castea" a string, asi poder mostrarlo.
            Console.WriteLine(objPluma1); //uso del casteo implicito


            Tinta objTinta2 = new Tinta(ETipoTinta.China, ConsoleColor.Yellow);
            Pluma objPluam2 = new Pluma("Stabillo", objTinta2, 7);

            infoObj2 = objPluam2;
            Console.WriteLine(objPluam2); //uso del casteo implicito

            #region Uso la sobrecarga del operador + de la clase pluma
            objPluma1 = objPluma1 + objTinta1;
            infoObj1 = objPluma1;
            Console.WriteLine(infoObj1);
            #endregion

            #region Uso la sobrecarga del operador - de la clase pluma
            objPluam2 = objPluam2 - objTinta2;
            infoObj2 = objPluam2;
            Console.WriteLine(infoObj2);
            #endregion


            Console.ReadLine();

        }
    }
}
