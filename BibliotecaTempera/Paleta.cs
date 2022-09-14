using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaTempera
{
    public class Paleta
    {
        private List<Tempera> listTemperas;
        private int cantidadMaximaColores;

        private Paleta()
        {
            this.listTemperas = new List<Tempera>();

        }

        private Paleta(int cantidadColores) : this() //llama al Paleta
        {
            this.cantidadMaximaColores = cantidadColores;
        }
        
        public static implicit operator Paleta(int cantidad)
        {
            return new Paleta(cantidad); //como es privada lso construcotres y solo podemos accder a traves de aca 
            //en el main seria Paleta otraPaleta = 2; -> cantidad de paletas creadas
        }

        private string Mostrrar()
        {
            StringBuilder mostrar = new StringBuilder();

            foreach (Tempera unaTemperaDeLaPaleta in this.listTemperas)
            {
                mostrar.AppendLine(Tempera.Mostrar(unaTemperaDeLaPaleta));
            }

            mostrar.AppendLine($"La cantidad maxima de colores: {this.cantidadMaximaColores}");

            return mostrar.ToString();
        }

        private int ObtenerIndice(Tempera unaTempera)
        {
            int indice = -1;
            int tamanio = this.listTemperas.Count;

            for (int i = 0; i < tamanio; i++)
            {
                if (this.listTemperas[i] == unaTempera)
                {
                    indice = i;
                    break;
                }
            }
                

            return indice;

        }
        /* Otra forma de hacerlo
         * int tam = listTemperas.Count;
            int index = -1;
            for (int i = 0; i < tam; i++)
            {
                if(listTemperas[i]==unaTempera)
                {
                    index = i;
                    break;
                }
            }

            return index
         */

        public static explicit operator string(Paleta unaPaleta)
        {
            return unaPaleta.Mostrrar();
        }

        public static bool operator == (Paleta unaPaleta, Tempera unaTempera)
        {
            //si el objeto de tipo Tempera esta en la lista de tipo Tempera 
            
            return (unaPaleta.ObtenerIndice(unaTempera) > -1);

        }

        public static bool operator != (Paleta unaPaleta, Tempera unaTempera)
        {
            return !(unaPaleta == unaTempera);
        }

        // +(Paleta, Tempera) : Paleta
        //*->si tempera está en paleta --> incrementa la cantidad en la tempera.
        //*->si no está --> agrega la tempera en la paleta, siempre y cuando, no supere la cantidad máxima de colores.

       public static Paleta operator + (Paleta unaPaleta, Tempera unaTempera)
       {
            int indice = unaPaleta.ObtenerIndice(unaTempera);

            if (indice > -1)
            {
                unaPaleta.listTemperas[indice] += 1; //se incrementa
            }
            else
            {
                if (unaPaleta.listTemperas.Count < unaPaleta.cantidadMaximaColores)
                {
                    unaPaleta.listTemperas.Add(unaTempera);
                }
            }

            return unaPaleta;
       }

          /*
         -(Paleta, Tempera) : Paleta
             *->si tempera está en paleta -> decrementa la cantidad en la tempera.
             *si la cantidad es menor o igual a cero, elimina la tempera (RemoveAt)
             */

        public static Paleta operator - (Paleta unaPaleta, Tempera unaTempera)
        {
            int indice = unaPaleta.ObtenerIndice(unaTempera);

            if (indice > -1)
            {
                unaPaleta.listTemperas[indice] += (-unaTempera); //se incrementa, sumanos algo negativo
                if (unaPaleta.listTemperas[indice] <= 0) //recordar que con el implicit lo convertimos a un numero
                {
                    unaPaleta.listTemperas.RemoveAt(indice);
                }
            }

            return unaPaleta;

        }

        /*+(Paleta, Paleta) : Paleta
        *->genera una paleta con los colores de ambas paletas.
        *->si temperas son iguales-->suma cantidades*/

        public static Paleta operator + (Paleta paletaUno, Paleta paletaDos)
        {
            int cantidadPaletaNueva;

            cantidadPaletaNueva = paletaUno.cantidadMaximaColores + paletaDos.cantidadMaximaColores;

            Paleta nuevaPaleta = new Paleta(cantidadPaletaNueva);

            nuevaPaleta.listTemperas = paletaUno.listTemperas;

            foreach (Tempera objTempera in paletaDos.listTemperas)
            {
                nuevaPaleta += objTempera;
            }
            return nuevaPaleta;
        }

        //Indexadores
        public Tempera this [int index]
        {
            get
            {
                if ( index < 0 || index > listTemperas.Count)
                {
                    return null;
                }

                return listTemperas[index];
            }
            set 
            {
                if ( !(index < 0 || index > listTemperas.Count) )
                {

                    listTemperas[index] = value;
                }
            }
        }
    }
}
