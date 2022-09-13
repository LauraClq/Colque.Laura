using System;
using System.Text;

namespace BibliotecaVeterinaria
{
    public class Clientes
    {
        private string nombre;
        private string apellido;
        private string direccion;
        private string telefono;
        private Mascotas[] mascotasClientes;

        public Clientes(string nombreCli, string apellidoCli, string direccionCli, string telefonoCli, Mascotas[] aMascotas)
        {
            this.nombre = nombreCli;
            this.apellido = apellidoCli;
            this.direccion = direccionCli;
            this.telefono = telefonoCli;
            this.mascotasClientes = aMascotas;
        }

        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("Informacion del cliente: ");
            sb.AppendLine($"Nombre: {this.nombre}");
            sb.AppendLine($"Apellido: {this.apellido}");
            sb.AppendLine($"Direccion: {this.direccion}");
            sb.AppendLine($"Telefono: {this.telefono}");
            sb.AppendLine($"\nMascotas del cliente:");

            foreach (Mascotas unaMascota in mascotasClientes)
            {
                sb.AppendLine($"{unaMascota.Mostrar()}"); //llama a mostrar de la clase Mascotas
            }

            return sb.ToString();
        }


    }
}
