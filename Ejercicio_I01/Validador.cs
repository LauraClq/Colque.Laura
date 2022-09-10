using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_I01
{
    class Validador
    {
        /// <summary>
        /// Valida que el numero ingresado este entre un rango
        /// </summary>
        /// <param name="valor">numero a validar</param>
        /// <param name="min">valor minimo</param>
        /// <param name="max">valor maximo</param>
        /// <returns></returns>
        static public bool Validar(int valor, int min, int max)
        {
            if((valor >= min) && (valor <= max))
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
