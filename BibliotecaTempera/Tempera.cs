using System;
using System.Text;

namespace BibliotecaTempera
{
    public class Tempera
    {
        private ConsoleColor color;
        private string marca;
        private Int32 cantidad;

        public string Marca 
        {
            get { return this.marca;  } 
        }
        public ConsoleColor Color 
        {
            get { return this.color; } 
        }

        #region Constructor de tres parametros
        public Tempera(ConsoleColor color, string marca, Int32 cantidad)
        {
            this.color = color;
            this.marca = marca;
            this.cantidad = cantidad;
        }
        #endregion

        #region Mostrar de clase, llamra al Mostrar de instancia que es privado, solo pordemos accederla a traves de la clase
        public static string Mostrar(Tempera unaTempera)
        {
            return unaTempera.Mostrar();
        }
        #endregion

        #region Mostrar de instancia que sera invocado por el Mostrar estatico
        private string Mostrar()
        {
            StringBuilder mostrar = new StringBuilder();

            mostrar.AppendLine($"\nLa marca es: {this.marca}");
            mostrar.AppendLine($"\nEl color es: {this.color}");
            mostrar.AppendLine($"\nLa cantidad es: {this.cantidad}");

            return mostrar.ToString();
        }
        #endregion

        #region Sobrecraga de operadores
        public static bool operator == (Tempera objTempera1, Tempera objTempera2)
        {
            bool resultado = false;

            if (objTempera1 is not null && objTempera2 is not null)
            {
            
               resultado = ((objTempera1.marca == objTempera2.marca) && (objTempera1.color == objTempera2.color));

            }
            else if(objTempera1 is null && objTempera2 is null)
            {
                resultado = true;
            }
            return resultado;
        }

        public static bool operator !=(Tempera objTempera1, Tempera objTempera2)
        {
            return !(objTempera1 == objTempera2);
        }
        #endregion

        #region Implicit -> Recibe un objeto de tipo Tempera y devuelve un entero
        /*Convierte implícitamente un objeto de tipo Tempera a int, en el main puedas tratar una 
         * Tempera como si fuera un int sin tener que accederle al atributo cantidad que es privado */
        public static implicit operator int (Tempera objetoTempera)
        {
            return objetoTempera.cantidad;
        }
        #endregion

        #region Sobrecarga de suma
        public static Tempera operator + (Tempera tempera1, Tempera tempera2)
        {

            if (tempera1 == tempera2)
            {
                tempera1 += tempera2.cantidad; //tepera1 utiliza a la sobrecarga de suma de tempera - int
              
            }

            return tempera1;
        }
        #endregion

        #region Sobrecarga de suma Tempera - int
        public static Tempera operator + (Tempera tempera1, int cantidad)
        {
            tempera1.cantidad += cantidad;

            return tempera1;
        }
        #endregion
    }
}
