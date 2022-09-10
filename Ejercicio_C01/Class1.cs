using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_C01
{
    class Class1
    {
        #region atributos de instancia, es decir NO son estaticos

        public string cadena;
        public Int32 numero;

        #endregion

        //simepre que un metodo sea estaico puedo utilizar atributos estaticos

        #region atributos estaticos o de la clase

        public static double doble;

        #endregion

        #region metodo de instancia

        public void MetodoInstancia()
        {
            //construtores -> le da un valor inicial a sus atributos. Object se encarga de atribuir un construtor por defecto
            // double mivalor = Class1.doble

            string cadena = "no soy atributo";
            Console.WriteLine("Valor cadena: {0}, Valor entero: {1}, Valor decimal: {2}",this.cadena,this.numero,Class1.doble);
            // this para los atributos de instancia.
            //  nombre de la clase (Class1) para los atributos estaticos.

        }

        #endregion

        #region metodo estatico o de la clase

        public static void MetodoDeClase()
        {
            Console.WriteLine("Valor doble: {0}",Class1.doble);
        }

        #endregion

        //Se puede trabajar con ambos tipos de constructores

        #region Constructor de instancia parametrizado
        //Solo sirve para dar un valor inicial a los atributos de instancia de mi clase.
        public Class1(int entero, string palabra)
        {
            this.numero = entero;
            this.cadena = palabra;
        }
        #endregion

        #region Construtor de instancia por default
        public Class1()
        {
            this.numero = 5;
            this.cadena = "valor inicial";
        }
        #endregion

        #region Constructor estatico 
        //No se epuede colocar un modificador de visibilidad
        //No puede recibir parametros
        static Class1()
        {
            Class1.doble = 34.4;
        }
        #endregion
    }
}
