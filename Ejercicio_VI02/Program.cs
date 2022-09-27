using System;
using System.Collections.Generic;

namespace Ejercicio_VI02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Numeros Locos II";

            Random aleatorio = new Random();
            //Lista
            List<int> listaAleatorios = new List<int>();
            //Pila
            Stack<int> pilaAleatorios = new Stack<int>();
            //Cola
            Queue<int> colaAleatorios = new Queue<int>();

            #region Lista
            //Carga de lista - recordar que el foreach no me permite modificarla
            for (int i = 0; i < 20; i++)
            {
                listaAleatorios.Add(aleatorio.Next(-20,20));
                while (listaAleatorios[i] == 0)
                {
                   listaAleatorios.Add(aleatorio.Next(-20, 20));
                }
            }

            Console.WriteLine("Lista Original\n");
            foreach (int auxList in listaAleatorios)
            {
                Console.WriteLine($"Lista: {auxList}");
            }

            Console.WriteLine("\nLista numeros positivos descendientes\n");
            listaAleatorios.Sort();
            listaAleatorios.Reverse();
            foreach (int item in listaAleatorios)
            {
                if (item > 0)
                {
                    Console.WriteLine($"Lista: {item}");
                }
            }

            Console.WriteLine("\nLista de numeros negativos crecientes\n");
            listaAleatorios.Sort();
            foreach (int item in listaAleatorios)
            {
                if (item < 0)
                {
                    Console.WriteLine($"Lista: {item}");
                }
            }
            #endregion

            #region Pila
            //Agrego todos los elementos de lista a pilaAleatorios
            foreach (int lista in listaAleatorios)
            {
              
               pilaAleatorios.Push(lista);

            }

            Console.WriteLine($"\nPilas Aleatorias\n");
            foreach (int pila in pilaAleatorios)
            {
                Console.WriteLine($"Pila: {pila}");
            }

            Console.WriteLine($"\nPilas numeros positivos decreciente\n");
            foreach (int pila in pilaAleatorios)
            {
                if (pila > 0)
                {
                    Console.WriteLine($"Pila: {pila}");
                }
            }

            Console.WriteLine($"\nPilas numeros negativos crecientes\n");
            foreach (int pila in pilaAleatorios)
            {
                if (pila < 0)
                {
                    Console.WriteLine($"Pila: {pila}");
                }
            }
            #endregion

            #region Cola
            //Agrego todos los elementos de lista a colaAleatorios
            foreach (int lista in listaAleatorios)
            {
                colaAleatorios.Enqueue(lista);
            }
            
           Console.WriteLine($"\nColas Aleatorias\n");
            foreach (int cola in colaAleatorios)
            {
                Console.WriteLine($"Cola: {cola}");
            }

            Console.WriteLine($"\nColas numeros positivos decreciente\n");
            foreach (int cola in colaAleatorios)
            {
                if (cola > 0)
                {
                    Console.WriteLine($"Cola: {cola}");
                }
            }

            Console.WriteLine($"\nColas numeros negativos creciente\n");
            foreach (int cola in colaAleatorios)
            {
                if (cola < 0)
                {
                    Console.WriteLine($"Cola: {cola}");
                }
            }
            #endregion
            Console.ReadKey();
        }
    }
}
