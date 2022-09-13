using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaVeterinaria
{
    public class Mascotas
    {
        private string especie;
        private string nombre;
        private DateTime fechaNacimiento;
        private string vacunas = "sin vacuna";

        public Mascotas(string especieMct, string nombreMct, DateTime fecha)
        {
            this.especie = especieMct;
            this.nombre = nombreMct;
            this.fechaNacimiento = fecha;
        }

        public string Mostrar()
        {
            StringBuilder datosMacotas = new StringBuilder();

            datosMacotas.AppendLine($"Especie: {this.especie}");
            datosMacotas.AppendLine($"Nombre: {this.nombre}");
            datosMacotas.AppendLine($"Fecha de Nacimiento {this.fechaNacimiento.ToShortDateString()}");
            datosMacotas.AppendLine($"Historial de vacunas: {this.vacunas}");

            return datosMacotas.ToString();
        }

        public void AgregarVacuna(string unaVacuna)
        {
            this.vacunas = unaVacuna;
        }
    }
}
