using System;
using System.Text;

namespace Bibiblioteca
{
    public class Estudiante
    {
        private static Random random; // Es una clase como Estudiante 
        private string apellido;
        private string legajo;
        private string nombre;
        private int notaPrimerParcial;
        private int notaSegundoParcial;

        static Estudiante()
        {
            Estudiante.random = new Random(); //Ramdom es un objeto que es de tipo referencia, es necesario instanciar
            // new nombreDeLaClase -> new Random();
        }

        public Estudiante(string nombre, string apellido, string legajo)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.legajo = legajo;
        }

        public void SetNotaPrimerParcial(int nota)
        {
            this.notaPrimerParcial = nota;
        }

        public void SetNotaSegundoParcial(int nota)
        {
            this.notaSegundoParcial = nota;
        }

        private float CalcularPromedio()
        {
            float promedio;

            promedio = (float)(this.notaPrimerParcial + this.notaSegundoParcial) / 2;

            return promedio;
        }

        public double CalcularNotaFinal()
        {
            double notaFinal;

            if (this.notaPrimerParcial >= 4 && this.notaSegundoParcial >= 4)
            {
                notaFinal = random.Next(6, 11);
            }
            else
            {
                notaFinal = -1;
            }

            return notaFinal;
        }

        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            double notaFinal;

            sb.AppendLine($"Nombre: {this.nombre}  Apellido: {this.apellido} Legajo:  {this.legajo}");
            sb.AppendLine($"Nota primer parcial: {this.notaPrimerParcial} Nota segundo parcial: {this.notaSegundoParcial}");
            sb.AppendLine($"Promedio: {CalcularPromedio()}");

            notaFinal = CalcularNotaFinal();

            if(notaFinal != -1)
            {
                sb.AppendLine($"Nota final: {notaFinal}");
            }
            else
            {
                sb.AppendLine("Alumno Desaprobado");
            }

            return sb.ToString();
        }



    }
}
