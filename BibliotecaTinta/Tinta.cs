using System;
using System.Text;

namespace BibliotecaTinta
{
    public class Tinta
    {
        public ConsoleColor color;
        public ETipoTinta tipo;

        //Construtor de 0 parametros
        public Tinta() 
        {
            this.color = ConsoleColor.Black;
            this.tipo = ETipoTinta.Comun;
        }

        //Construtor de 1 parametro
        public Tinta(ETipoTinta tinta) : this() //este llama al primero
        {
            this.tipo = tinta;
        }

        //Construtor de 2 parametro
        public Tinta(ETipoTinta tinta, ConsoleColor color) : this(tinta) //este llama al segundo
        {
            this.color = color;
        }

        private string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"\nEl tipo: {this.tipo}");
            sb.AppendLine($"El color: {this.color}");

            return sb.ToString();
        }

        public static string Mostrar(Tinta tinta1)
        {
            return tinta1.Mostrar();
        }

        public static explicit operator string(Tinta tinta1)
        {
            return tinta1.Mostrar();
        }

        #region Sobrecarga de operadores
        public static bool operator == (Tinta tinta1, Tinta tinta2)
        {
            return tinta1.color == tinta2.color && tinta1.tipo == tinta2.tipo; //si se cumple retorna true
            /*
             * Otra forma de hacerlo:
             * 
             * bool retorno = false;
             * if(tinta1.color == tinta2.color && tinta1.tipo == tinta2.tipo)
             * {
             *  retorno = true;
             * }
             * return retorno;
             */
        }

        public static bool operator != (Tinta tinta1, Tinta tinta2)
        {
            return !(tinta1 == tinta2);
        }
        #endregion

    }
}
