using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_I02
{
    class Validador
    {
        /// <summary>
        /// Valida la respuesta del usuario, si es S devuelve true o false si cualquier otra respuesta
        /// </summary>
        /// <param name="respuesta"> valor a recibir por el usuario </param>
        /// <returns></returns>
        static public bool ValidarRespuesta(char respuesta)
        {
            if (respuesta == 'S')
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
