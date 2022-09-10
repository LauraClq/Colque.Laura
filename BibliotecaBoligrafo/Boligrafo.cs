using System;

namespace BibliotecaBoligrafo
{
    public class Boligrafo
    {
        private short tinta; // de tipo enumerado
        private ConsoleColor color;
        public const short cantidadTintaMaxima = 100;

        public Boligrafo(short tinta, ConsoleColor color)
        {
            this.color = color;
            this.SetTinta(tinta);
        }

        #region Recuperar desde afuera de la clase el valor de algun atributo
        public ConsoleColor GetColor()
        {
            return this.color;
        }

        public short GetTinta()
        {
            return this.tinta;
        }

        #endregion

        #region  Metodo privado 
        private void SetTinta(short tinta)
        {
            int resultante = 0;
            short positivo;

            if (tinta <= 0) //Si tinta <= 0, quitar tinta
            {
                positivo = Convert.ToInt16(tinta * -1); //lo multiplo por -1 para que sea positivo

                resultante = this.tinta - positivo; // resultante = cantidad de tinta a quitar
                // + porque tinta sera un numero negativo y las resta no se realizara
                if (resultante >= 0 && resultante <= cantidadTintaMaxima)
                {
                    this.tinta -= positivo;
                }
            }
            else // En caso contrario, cargar tinta
            {
                this.tinta = tinta;

            }
          
        }
        #endregion

        public void Recargar() //Recargo en su nivel maximo
        {
            this.tinta = cantidadTintaMaxima;
        }

        public bool Pintar(short gasto, out string dibujo)
        {
            bool retorno;
            int cantidadVueltas; // me indica la cantiadad de vueltas a dar
            dibujo = "";

            if (this.tinta == 0) //Si no habia tinta retornara una cadena vacia
            {
                retorno = false;
            }
            else // En caso que haya tinta
            {
                if (gasto <= this.tinta) //Si el gasto es menor a la tinta que hay, dibujo = cantidad de gasto
                {
                    this.SetTinta(Convert.ToInt16(gasto * -1));
                    cantidadVueltas = gasto;
                }
                else
                {
                    //Si el gasto es mayor que hay de tinta, dibujo = solo se gastara lo que quede de tinta
                    this.SetTinta(Convert.ToInt16(this.tinta * 1));
                    cantidadVueltas = this.tinta;
                }

                for (int i = 0; i < cantidadVueltas; i++)
                {
                    dibujo += "*";
                }
                retorno = true;
            }

            return retorno;
        }
    }
}
