using System;

namespace BibliotecaConversorBinario
{
    public class NumeroBinario
    {
        private string numero;
        /*
        private NumeroBinario(string numeroBinario)
        {
            this.numero = numeroBinario;
        }

        public string NumBinario
        {
            get { return numero; }
        }

        public static string operator +(NumeroBinario numBinario, NumeroDecimal numDecimal)
        {
            double suma;

            suma = numDecimal.NumDecimal + ((NumeroDecimal)numBinario).NumDecimal;
            return Corversor.ConvertirDecimalABinario(Convert.ToInt32(suma));

        }

        public static string operator -(NumeroBinario numBinario, NumeroDecimal numDecimal)
        {
            double resta;

            resta = numDecimal.NumDecimal - ((NumeroDecimal)numBinario).NumDecimal;
            return Corversor.ConvertirDecimalABinario(Convert.ToInt32(resta));

        }

        public static bool operator ==(NumeroBinario numBinario, NumeroDecimal numDecimal)
        {

            return numBinario.numero == ((NumeroBinario)numDecimal).NumBinario;
            
        }

        public static bool operator !=(NumeroBinario numBinario, NumeroDecimal numDecimal)
        {

            return !(numBinario == numDecimal);

        }

        public static explicit operator string(NumeroBinario objBinario)
        {
            return objBinario.numero;
        }


        public static implicit operator NumeroBinario(string numero)
        {
            return new NumeroBinario(numero);
        }*/
    }
}
