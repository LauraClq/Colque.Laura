using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicicio_V02bis
{
    public class Tablas
    {
        public static string TablasMultiplcar(int numero)
        {
            StringBuilder sb = new StringBuilder();
            int resultado;

            for (int i = 0; i <= 10; i++)
            {
                resultado = numero * i;

                sb.AppendLine($"{numero} x {i} = {resultado}-");
                //con el - separo cada interacion es como un salto de linea
            }
            return sb.ToString();
        }
        
    }
}
