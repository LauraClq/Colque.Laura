using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaBilletes
{
    public class Dolar
    {
        private double cantidad;
        private static double cotzRespectoDolar;

        static Dolar()
        {
            cotzRespectoDolar = 1;
        }

        public Dolar(double cantidad)
        {
            this.cantidad = cantidad;
        }

        public double GetCantidad()
        {
            return cantidad;
        }

        public static double GetCotizacion()
        {
            return cotzRespectoDolar;
        }

        public static explicit operator Euro(Dolar d)
        {
            return new Euro(Euro.GetCotizacion() * d.cantidad);

        }

        public static explicit operator Pesos(Dolar d)
        {
            return new Pesos(Pesos.GetCotizacion() * d.cantidad);
        }

        public static implicit operator Dolar(double dCantidad)
        {
            return new Dolar(dCantidad);
        }

        #region Suma de Dolares + Euros
        public static Dolar operator +(Dolar dolares, Euro euros)
        {
            return new Dolar(dolares.cantidad + ((Dolar)euros).cantidad);
        }
        #endregion

        #region Suma de Dolares + Pesos
        public static Dolar operator +(Dolar dolares, Pesos pesos)
        {
            return new Dolar(dolares.cantidad + ((Dolar)pesos).cantidad);
        }
        #endregion

        #region Resta de Dolares - Euros
        public static Dolar operator -(Dolar dolares, Euro euros)
        {
            return new Dolar(dolares.cantidad - ((Dolar)euros).cantidad);
        }
        #endregion

        #region Resta de Dolares - Pesos
        public static Dolar operator -(Dolar dolares, Pesos pesos)
        {
            return new Dolar(dolares.cantidad - ((Dolar)pesos).cantidad);
        }
        #endregion


    }
}
