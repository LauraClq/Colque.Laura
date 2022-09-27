using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaVehiculo
{
    public class Camion : Vehiculo
    {
        protected float tara;

        public Camion(float tara, string patente, byte cantRuedas, Emarcas marcas) :base(patente, cantRuedas, marcas)
        {
            this.tara = tara;
        }

        public string MostrarCamion()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"{base.Mostrar()}\n La tara es: {this.tara}");

            return sb.ToString();
        }
    }
}
