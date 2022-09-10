using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_I01bis
{
    class Sello
    {
        static public string mensaje; //atributo mensaje - identificador string
        static public ConsoleColor color; //atributo color - identificador ConsoleColor
        
        static public string Imprimir()
        {
            string mensajeMostrar;
            mensajeMostrar = Sello.ArmarFormatoMensaje();
            return mensajeMostrar;
        }

        static public void Borrar()
        {
            Sello.mensaje = ".";
        }

        static public void ImprimirEnColor()
        {
            Console.ForegroundColor = Sello.color;
            Console.WriteLine(Sello.Imprimir()); //Muestro el mensaje invicando el metodo Imprimir
            Console.ResetColor(); //Reseteo al color por default
        }

        static public string ArmarFormatoMensaje()
        {
            string formato = "";
            string texto;
            int largo = Sello.mensaje.Length; //Length es una prodiedad de la clase Sello

            for (int i = 0; i < largo+2; i++) //Se le suma len+2 para que quede todo encasillado por los * de la izq y der
            {
                formato += "*"; //en cada interacion va acumulando los *
            }
            texto =  formato + "\n" + "*" + Sello.mensaje + "*" + "\n" + formato;
            // **** +  salto +  * el que va a la izquerda + mensaje + * el de la derecha + salto  + ****

            return texto;
        }
        
    }
}
