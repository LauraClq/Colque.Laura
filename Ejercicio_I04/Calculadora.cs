using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_I04
{
    class Calculadora
    {
        public static float Calcular(int primerOperando, int segundoOperando, char operador)
        {
            float resultado = -1;

            switch (operador)
            {
                case '+':
                    resultado = primerOperando + segundoOperando;
                    break;
                case '-':
                    resultado = primerOperando - segundoOperando;
                    break;
                case '*':
                    resultado = primerOperando * segundoOperando;
                    break;
                case '/':
                    if (Calculadora.Validar(segundoOperando))
                    {
                        resultado = (float) primerOperando / segundoOperando;
                    }
                    break;
                default:
                    resultado = -2;
                    break;
            }

            return resultado;
        }

        private static bool Validar(int segundoOperando)
        {
            if (segundoOperando != 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
