using System;
using System.Text;

namespace BibliotecaPersona
{
    public class Persona
    {
        string nombre;
        DateTime fechaDeNacimiento;
        int dni;

        public Persona()
        {
            this.nombre = "";
            DateTime fecha = DateTime.Today;
            this.fechaDeNacimiento = fecha;
            this.dni = 0;
        }

        #region Getter atributo nombre
        public string GetNombre()
        {
            return this.nombre;
        }
        #endregion

        #region Getter atributo fechaNacimiento
        public DateTime GetFechaDeNacimiento()
        {
            return this.fechaDeNacimiento;
        }
        #endregion

        #region Getter atributo dni
        public int GetDNI()
        {
            return this.dni;
        }
        #endregion

        #region Setter atributo nombre
        public void SetNombre(string name)
        {
            this.nombre = name;
        }
        #endregion

        #region Setter atributo fechaDeNacimiento
        public void SetFechaDeNacimiento(DateTime fecha)
        {
            this.fechaDeNacimiento = fecha;
;       }
        #endregion

        #region Setter atributo DNI
        public void SetDNI(int documento)
        {
            this.dni = documento;
        }
        #endregion

        private int CalcularEdad()
        {
            int edad = 0;
            DateTime fechaActual = DateTime.Today;

            if (this.fechaDeNacimiento > fechaActual)
            {
                Console.WriteLine("La fecha de nacimiento es mayor que la actual.");
                
            }
            else
            {
                edad = fechaActual.Year - this.fechaDeNacimiento.Year;

                if(this.fechaDeNacimiento.Month > fechaActual.Month)
                {
                    edad = edad - 1;
                }
            }
            return edad;
        }

        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Datos de la persona: ");
            sb.AppendLine($"Nombre: {this.nombre}");
            sb.AppendLine($"DNI: {this.dni}");
            sb.AppendLine($"Fecha de nacimiento: {this.fechaDeNacimiento.ToShortDateString()}");
            sb.AppendLine($"Edad actual: {CalcularEdad()}");

            return sb.ToString();

        }
        public string EsMayorDeEdad()
        {
            string cadena;
            int edad;

            edad = CalcularEdad();

            if (edad > 18)
            {
                cadena = "Es mayor de edad";
            }
            else
            {
                cadena = "Es menor de edad";
            }

            return cadena;
        }
    }
}
