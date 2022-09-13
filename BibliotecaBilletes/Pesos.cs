using System;

namespace BibliotecaBilletes
{
    public class Pesos
    {
        private double cantidad;
        private static double cotzRespectoDolar;

        static Pesos()
        {
            cotzRespectoDolar = 1 / 66; ;
        }

        public Pesos(double cantidad)
        {
            this.cantidad = cantidad;
        }

        public Pesos(double cantidad, double cotizacion) : this(cantidad)
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

        public static explicit operator Dolar(Pesos p)
        {
            return new Dolar(Dolar.GetCotizacion() * p.cantidad); // retorna un nuevo objeto

        }

        public static explicit operator Euro(Pesos p)
        {
            return new Euro(Euro.GetCotizacion() * p.cantidad); // retorna un nuevo objeto
        }

        public static implicit operator Pesos(double pCantidad)
        {
            return new Pesos(pCantidad);
        }

        #region Suma de Pesos + Dolares
        public static Pesos operator +(Pesos pesos, Dolar dolares)
        {
            return new Pesos(pesos.cantidad + ((Pesos)dolares).cantidad);
        }
        #endregion

        #region Suma de Pesos + Euros
        public static Pesos operator +(Pesos pesos, Euro euros)
        {
            return new Pesos(pesos.cantidad + ((Pesos)euros).cantidad);
        }
        #endregion

        #region Resta de Pesos - Dolares
        public static Pesos operator -(Pesos pesos, Dolar dolares)
        {
            return new Pesos(pesos.cantidad - ((Pesos)dolares).cantidad);
        }
        #endregion

        #region Resta de Pesos - Euros
        public static Pesos operator -(Pesos pesos, Euro euros)
        {
            return new Pesos(pesos.cantidad - ((Pesos)euros).cantidad);
        }
        #endregion
    }
}
