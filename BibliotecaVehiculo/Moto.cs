using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaVehiculo
{
    public class Moto : Vehiculo
    {
        protected float cilindrada;

        public Moto(float cilindrada, string patente, byte cantRuedas, Emarcas marcas) : base(patente, cantRuedas, marcas)
        {
            this.cilindrada = cilindrada;
        }

        public string MostrarMoto()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"{base.Mostrar()}\n La cilindrada es: {this.cilindrada}");

            return sb.ToString();
        }
    }
}
