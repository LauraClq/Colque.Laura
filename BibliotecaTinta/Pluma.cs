using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaTinta
{
    public class Pluma
    {
        public string marca;
        public Tinta tinta;
        public int cantidad;

        public Pluma()
        {
            this.marca = "Sin marca";
            this.tinta = null;
            this.cantidad = 1;
        }

        public Pluma(string marca) : this ()
        {
            this.marca = marca;
        }

        public Pluma(string marca, Tinta tinta) : this(marca)
        {
            this.tinta = tinta;
        }

        public Pluma(string marca, Tinta tinta, int cantidad) : this(marca, tinta)
        {
            this.cantidad = cantidad;
        }

        private string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"La marca es: {this.marca}");
            sb.AppendLine($"\nInformacion de la tinta: {(string)tinta}"); //o sb.AppendLine(Tinta.Mostrar(tinta)); 
            //llama a Mostar() de la class Tinta que infromar el tipo de tinta y el color.
            //esta de manera explicita asi que por eso lo "casteamos" (string).
            sb.AppendLine($"La cantidad es : {this.cantidad}");

            return sb.ToString();
        }

        public static bool operator == (Pluma pluma1, Tinta tinta1)
        {
            return pluma1.tinta == tinta1; //si las tintas son iguales retorna true
        }

        public static bool operator != (Pluma pluma1, Tinta tinta1)
        {
            return !(pluma1.tinta == tinta1);
        }

        public static Pluma operator + (Pluma pluma1, Tinta tinta1)
        {
            
            if(pluma1 == tinta1) //se fija lo que devolvio bool operator
            {
                pluma1.cantidad++; //incrementa la cantidad si son iguales
            }

            return pluma1;
        }

        public static Pluma operator - (Pluma pluma1, Tinta tinta1)
        {
            if (pluma1 == tinta1)
            {
                pluma1.cantidad--; // decrementa la cantidad si son iguales
            }

            return pluma1;
        }

        //El implicit lo que hace es "trasformar" un objeto de tipo pluma en string
        public static implicit operator string(Pluma pluma)
        {
            return pluma.Mostrar();
        }
    }
}
