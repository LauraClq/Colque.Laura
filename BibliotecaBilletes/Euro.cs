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

        #region Comparar cantiadades de Euros a Dolares
        public static bool operator ==(Euro euros, Dolar dolares)
        {
            return euros.cantidad == dolares.GetCantidad();
        }

        public static bool operator !=(Euro euros, Dolar dolares)
        {
            return !(euros == dolares);
        }
        #endregion

        #region Comparar cantiadades de Euros a Pesos
        public static bool operator ==(Euro euros, Pesos pesos)
        {
            return euros.cantidad == pesos.GetCantidad();
        }

        public static bool operator !=(Euro euros, Pesos pesos)
        {
            return !(euros == pesos);
        }
        #endregion

        #region Comparar cantiadades de Euro a Euro
        public static bool operator ==(Euro euro1, Euro euro2)
        {
            return euro1.cantidad == euro2.cantidad;
        }

        public static bool operator !=(Euro euro1, Euro euro2)
        {
            return !(euro1 == euro2);
        }
        #endregion
    }
}
