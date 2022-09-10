using System;
using System.Text;

namespace BibliotecaCuenta
{
    public class Cuenta
    {
        public string titular;
        public double cantidad;

        //Constructor
        public Cuenta()
        {
            this.titular = "Homero J. Simpson";
            this.cantidad = 40060.56;
        }

        //Getters
        public string GetTitular()
        {
            return this.titular;
        }

        public double GetCantidad()
        {
            return this.cantidad;
        }

        //metodo Mostrar
        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Datos de la cuenta");
            sb.AppendLine($"Titular de la cuenta: {this.titular}");
            sb.AppendLine($"cantidad: {this.cantidad}");

            return sb.ToString();
                
        }
        public void Ingresar(double acreditar)
        {
            //double acreditado = 0;

            if(acreditar > 0)
            {
                this.cantidad = this.cantidad + acreditar;
            }

        }

        public void Retirar(double debitar)
        {
            //double extraer;

            this.cantidad = this.cantidad - debitar;

        }
    }
}
