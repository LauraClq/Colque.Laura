using System;

namespace Ejercicio_VI01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Numeros Locos";

            int[] arrayNumerosAaleatorios = new int[20];

            Random aleatorio = new Random(); //genera numero randon

            //Carga del array con numeros aleatorios
            for (int i = 0; i < arrayNumerosAaleatorios.Length; i++)
            {
                arrayNumerosAaleatorios[i] = aleatorio.Next(-20, 20); //esta de aca
                //en cada iteracion carga un numero negativo o positivo entre ese rango

                while (arrayNumerosAaleatorios[i] == 0)//si ve que el numero cargado no es 0 va al principal bucle for
                {
                    arrayNumerosAaleatorios[i] = aleatorio.Next(-20, 20);
                    //si el numero que cargo es 0 de nuevo entra al bucle para que le asigne otro numero
                    //solo entrara al bucle si el numero cargado es 0 para poder asignarles otro ramdom
                }
              
            }

            Console.WriteLine("Array Original\n");
            foreach (int item in arrayNumerosAaleatorios)
            {
                Console.WriteLine($"Numero: {item}");
            }

            Console.WriteLine("Array positivos en forma decreciente\n");
            Array.Sort(arrayNumerosAaleatorios); //primero los ordeno
            Array.Reverse(arrayNumerosAaleatorios); //luego hago de forma descendiente
            foreach (int item in arrayNumerosAaleatorios)
            {
                if (item > 0)
                {
                    Console.WriteLine($"Numero: {item}");
                }
                
            }

            Console.WriteLine("Array negativos en forma creciente\n");
            Array.Sort(arrayNumerosAaleatorios);
            foreach (int item in arrayNumerosAaleatorios)
            {
                if (item < 0)
                {
                    Console.WriteLine($"Numero: {item}");
                }
            }
            Console.ReadKey();

        }
    }
}
