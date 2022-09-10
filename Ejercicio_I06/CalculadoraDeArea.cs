using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_I06
{
    class CalculadoraDeArea
    {
        public static double CalcularAreaCuadrado(double longitudLado) 
        {
            double resultado = 0;

            resultado = Math.Pow(longitudLado,2);

            return resultado;
        }

        public static double CalcularAreaTriangulo(double baseTriangulo, double altura) 
        {
            double resultado = 0;

            resultado = (baseTriangulo * altura) / 2;

            return resultado;
        }

        public static double CalcularAreaCirculo(double radio) 
        {
            double resultado = 0;

            resultado = Math.PI * Math.Pow(radio, 2);

            return resultado;
        }
    }
}
