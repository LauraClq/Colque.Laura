using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaBilletes
{
    public class Euro
    {
        private double cantidad;
        private static double cotzRespectoDolar;

        static Euro()
        {
            cotzRespectoDolar = 1 / 1.08;
        }

        public Euro(double cantidad)
        {
            this.cantidad = cantidad;
        }

        public Euro(double cantidad, double cotizacion) : this(cantidad)
        {
            cotzRespectoDolar = cotizacion;
        }
        public double GetCantidad()
        {
            return cantidad;
        }

        public static double GetCotizacion()
        {
            return cotzRespectoDolar;
        }
        
        public static explicit operator Dolar(Euro e)
        {
            return new Dolar(Euro.GetCotizacion() * e.cantidad);
        }

        public static explicit operator Pesos(Euro e)
        {
            return new Pesos(Euro.GetCotizacion() * e.cantidad);
        }

        public static implicit operator Euro(double eCantiadad)
        {
            return new Euro(eCantiadad);
        }

        #region Suma de Euros + Dolares
        public static Euro operator +(Euro euros, Dolar dolares)
        {
            return new Euro(euros.cantidad + ((Euro)dolares).cantidad);
        }
        #endregion

        #region Suma de Euros + Pesos 
        public static Euro operator +(Euro euros, Pesos pesos)
        {
            return new Euro(euros.cantidad + ((Euro)pesos).cantidad);
        }
        #endregion

        #region Resta de Euros - Dolares
        public static Euro operator -(Euro euros, Dolar dolares)
        {
            return new Euro(euros.cantidad - ((Euro)dolares).cantidad);
        }
        #endregion

        #region Resta de Euros - Pesos 
        public static Euro operator -(Euro euros, Pesos pesos)
        {
            return new Euro(euros.cantidad - ((Euro)pesos).cantidad);
        }
        #endregion
    }
}
