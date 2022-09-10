using System;

namespace Ejercicio_07
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Recibo de sueldo";
            Console.WriteLine("Calculo de sueldo\n" + "----------------");
            
            int cantidadEmpleados;
            float valorHora;
            string nombre;
            int aniosAntigueadad;
            float horasPorMes;

            float totalHoras;
            float totalAnios;
            float totalBruto;
            float totalNeto;
            float descuentosConceptos;
            float acumuladorNeto = 0;

            Console.Write("Ingrese la cantidad de empleados a calcular el sueldo: ");
            cantidadEmpleados = int.Parse(Console.ReadLine());
            Console.WriteLine("\n");

            for (int i = 0; i < cantidadEmpleados; i++)
            {
                Console.Write("Ingrese el valor por hora del empleado: ");
                valorHora = float.Parse(Console.ReadLine());

                Console.Write("Ingese el nombre del empleado: ");
                nombre = Console.ReadLine();

                Console.Write("Ingrese los anios de antiguedad: ");
                aniosAntigueadad = int.Parse(Console.ReadLine());

                Console.Write("Ingrese la cantidad de horas trabajadas en el mes: ");
                horasPorMes = float.Parse(Console.ReadLine());

                totalHoras = valorHora * horasPorMes;
                totalAnios = aniosAntigueadad * 150;
                totalBruto = totalHoras + totalAnios;
                descuentosConceptos = (float)(totalBruto * 1.13) - totalBruto;
                totalNeto = totalBruto - descuentosConceptos;
                acumuladorNeto += totalNeto;

                Console.WriteLine("\n--------------------------------\n" +
                    "Nombre: "+ nombre + "\n" + 
                    "Antiguedad: "+ aniosAntigueadad + "\n" +
                    "Valor por hora: " + valorHora + "\n" +
                    "Total a cobrar bruto: " + totalBruto + "\n" +
                    "--------------------------------");
            }
            Console.WriteLine("Total a cobrar neto de todos los empleados: " + acumuladorNeto);
            Console.ReadLine();
  

        }
    }
}
