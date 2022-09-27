using System;
using System.Text;

namespace BibliotecaVehiculo
{
    public class Auto : Vehiculo
    {
        protected int cantidadAsientos;

        public Auto(int cantidadAsientos, string patente, byte cantRuedas, Emarcas marcas) : base(patente, cantRuedas, marcas)
        {
            this.cantidadAsientos = cantidadAsientos;
        }

        public string MostrarAuto()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"{base.Mostrar()}\nCantidad de asientos: {this.cantidadAsientos}");

            return sb.ToString();
        }
    }
}
