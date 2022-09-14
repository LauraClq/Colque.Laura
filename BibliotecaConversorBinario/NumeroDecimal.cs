using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaConversorBinario
{
    public class NumeroDecimal
    {
        private double numero;

        private NumeroDecimal(double numero)
        {
          this.numero = numero;
        }

        public double NumDecimal
        {
            get { return numero; }
        }


    }
}
