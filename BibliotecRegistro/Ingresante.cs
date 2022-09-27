using System;
using System.Text;

namespace BibliotecRegistro
{
    public class Ingresante
    {
        private string[] curso;
        private string direccion;
        private int edad;
        private string genero;
        private string nombre;
        private string pais;

        public Ingresante(string nombre, string direccion, string genero, string pais, string[] cursos, int edad)
        {
            this.nombre = nombre;
            this.direccion = direccion;
            this.edad = edad;
            this.genero = genero;
            this.pais = pais;
            this.curso = cursos;
            this.edad = edad;
        }

        public string Mostrar()
        {
            StringBuilder mostrar = new StringBuilder();

            mostrar.AppendLine($"Informacion del ingresante");
            mostrar.AppendLine($"Nombre: {this.nombre}");
            mostrar.AppendLine($"Direccion: {this.direccion}");
            mostrar.AppendLine($"Genero: {this.genero}");
            mostrar.AppendLine($"Pais: {this.pais}");
            mostrar.AppendLine($"Edad: {this.edad}");
            mostrar.AppendLine($"Cursos/s:");

            for (int i = 0; i < curso.Length; i++)
            {
                mostrar.AppendLine($"{curso[i]}");
            }

            return mostrar.ToString();

        }


        
    }
}
