using System;
using BibliotecaBilletes;

namespace Ejercicio_IV_02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Cotizador";

            Euro objEuro = new Euro(12, 0.809f);
            Pesos objPeso = new Pesos(2, 20.1655f);
            Dolar objDolar = new Dolar(4);

            Pesos p1 = 10;
            Pesos p2 = new Pesos(10);

            Euro sumaEuro = objEuro + objDolar;

            Console.WriteLine(@"Euro + Dólar (€18,09xx): {0}", sumaEuro.GetCantidad());
            sumaEuro = objEuro + objPeso;
            Console.WriteLine("Euro + Pesos (€10,40xx): {0}", sumaEuro.GetCantidad());
            Console.WriteLine("----------------------------------------------");

            Dolar sumaDolar = objDolar + objEuro;
   
            Console.WriteLine(@"Dolar + Euro (U$S22,36xx): {0}", sumaDolar.GetCantidad());
            sumaDolar = objDolar + objPeso;
            Console.WriteLine("Dolar + Pesos (U$S10,49xx): {0}", sumaEuro.GetCantidad());
            Console.WriteLine("----------------------------------------------");

            Pesos sumaPeso = objPeso + objDolar;

            Console.WriteLine(@"Peso + Dólar ($211,65xx): {0}", sumaPeso.GetCantidad());
            sumaPeso = objPeso + objEuro;
            Console.WriteLine("Pesos + Euro ($259,26xx): {0}", sumaPeso.GetCantidad());
            Console.WriteLine("----------------------------------------------");

            Console.ReadLine();
        }
    }
}
