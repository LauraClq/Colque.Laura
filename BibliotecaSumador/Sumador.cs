using System;
using System.Text;

namespace BibliotecaSumador
{
    public class Sumador
    {
        private int cantidadSumas;

        //constructor
        public Sumador(int cantidadSumas)
        {
            this.cantidadSumas = cantidadSumas;
        }
        public Sumador() : this(0)
        {

        }

        public long Sumar(long a, long b)
        {
            long suma;

            this.cantidadSumas++;
            suma = a + b;

            return suma;
        }

        public string Sumar(string a, string b)
        {
            string cadena;

            this.cantidadSumas++;
            cadena = a + b;

            return cadena;
        }
        public int Cantidad()
        {
            return this.cantidadSumas;
        }

        public static explicit operator int(Sumador suma)
        {
            return suma.cantidadSumas;
        }

        public static long operator +(Sumador suma1, Sumador suma2)
        {
            return (int)suma1 + (int)suma2; //suma de dos objetos, lo casteo de forma explicita a int 
            //para poder sumarlos ya que la variable cantidadSumas es de tipo int
        }

        public static bool operator |(Sumador suma1, Sumador suma2)
        {
            bool flag = false;

            if ((int)suma1 == (int)suma2) //cateo explicito para poder comparar los objetos
            {
                flag = true;
            }

            return flag;
        }
    }
}
