using System;
using MiBiblioteca;

namespace Ejercicio_C01
{
    class Program
    {
        static void Main(string[] args)
        {
            //construtor inicialzo en atributo en 0
            double valor = Class1.doble;

            Class1.MetodoDeClase();

            //Instancio la clase Class1
            Class1 objeto = new Class1(5,"hola"); //como es de referencia se inicializa en null

            //accedo a traves de una instacia de la clase es una construccion estatica.
            objeto.cadena = "algo";
            objeto.numero = 5;
            objeto.MetodoInstancia();

            Class1 instacia = new Class1(6,"chau");
            instacia.cadena = "algoqueescribir";

            MiClaseLibreria.variable = true;
            MiClaseLibreria objecto = new MiClaseLibreria();
            //Sin especificar el using seria la declaracion MiLibreria.MiClaseLibreria objecto = new MiClaseLibreria();
        }
    }
}
