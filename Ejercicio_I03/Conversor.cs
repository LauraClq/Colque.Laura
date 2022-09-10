using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_I03
{
    class Conversor
    {
        static public string ConvertirDecimalABinario(int numeroEntero)
        {
            string binario = "";

            
                while (numeroEntero > 0 )
                {
                    if (numeroEntero % 2 == 0)
                    {
                        binario = "0" + binario;
                    }
                    else
                    {
                        binario = "1" + binario;
                    }

                    numeroEntero = (int) numeroEntero / 2;
                }
            
            
            return binario;
        }

        static public int ConvertirBinarioADecimal(int numeroEntero)
        {
            int numeroBase;
            int numeroDecimal = 0;
            int secuencia = 1;

            while (numeroEntero > 0)
            {
                numeroBase = numeroEntero % 10;
                numeroEntero = numeroEntero / 10;

                numeroDecimal = numeroDecimal + (numeroBase * secuencia);

                secuencia = secuencia * 2;
            }

            return numeroDecimal;
        }
    }
}
