using System;

namespace BibliotecaCosa
{
    public class Cosa
    {
        private int entero;
        private string cadena;
        private DateTime fehca;

        public void EstablecerValor(int entero)
        {
            this.entero = entero;
        }

        public void EstablecerValor(string cadena) 
        {
            this.cadena = cadena;
        }

        public void EstablecerValor( DateTime fecha)
        {
            
            this.fehca = fecha;
        }

        //Los metodos Mostrar son lo mismo
        private string Mostrar() 
        {
            return $"{this.entero} - {this.cadena} - {this.fehca.ToShortDateString()}";
        }

        public static string Mostrar(Cosa objeto)
        {
            return objeto.Mostrar();
            //internamente reutilizamos 
            //el metodo publico utiliza el metodo privado
        }

        public Cosa(DateTime fecha, int numero, string cadena) : this(numero,cadena)
        {
            this.fehca = fecha;
        }

        public Cosa(int numero, string cadena) : this(cadena)
        {
            this.entero = numero;
        }

        public Cosa(string cadena) : this()
        {
            this.cadena = cadena;
        }

        public Cosa()
        {
            DateTime fecha = DateTime.Now;
            this.fehca = fecha;
            this.entero = 10;
            this.cadena = "Sin valor";
        }
    }
}
