using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaVehiculo
{
    public abstract class Vehiculo
    {
        protected string patente;
        protected byte cantRueadas;
        protected Emarcas marca;

        public Vehiculo(string patente, byte cantRueadas, Emarcas marca)
        {
            this.patente = patente;
            this.cantRueadas = cantRueadas;
            this.marca = marca;
        }

        public string Patente { get => patente; }
        public Emarcas Marca { get => marca; }

        protected string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"La patente es: {this.patente}");
            sb.AppendLine($"La cantidad de ruedas: {this.cantRueadas}");
            sb.AppendLine($"La marca es: {this.marca.ToString()}");

            return sb.ToString();
        }

        #region Sobrecarga de operadores
        public static bool operator ==(Vehiculo vehiculo1, Vehiculo vehiculo2)
        {
            return (vehiculo1.patente == vehiculo2.patente && vehiculo1.marca == vehiculo2.marca);
        }

        public static bool operator !=(Vehiculo vehiculo1, Vehiculo vehiculo2)
        {
            return !(vehiculo1 == vehiculo2);
        }
        #endregion

        #region Comparamos con Equals (sobreescribimos)
        public override bool Equals(object obj) 
        {
            //Recibimos un parametro que puede ser de cualquier tipo -> object puede ser cualquier cosa
            //el metodo esta generado con esta firma obj, no la puedo cambiar 
            //si puedo cambiar el contenido, puedo coincidir lo que tengo en mi sobreoperador
            bool retorno = false;

            if ( obj is Vehiculo)
            {
                //lo comparo con la representacion de un objeto -> this
               retorno = this == ((Vehiculo)obj);
            }
            return retorno;
        }
        #endregion

        #region Otra forma de comparacion es el GetHashCode
        //Retorna un valor entero, no puedo modificar la firma
        public override int GetHashCode()
        {
            //Devuelve una representacion numerica, lo que era formato de cadena de cualquier objecto
            return base.GetHashCode();
        }
        #endregion

        #region Retorna en representacion de cadena, cualquier objeto
        public override string ToString()
        {
            return this.Mostrar();
        }
        #endregion
    }
}
