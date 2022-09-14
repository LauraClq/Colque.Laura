using System;
using BibliotecaTempera;

namespace Ejercicio_VI01bis
{
    class Program
    {
        static void Main(string[] args)
        {
            //Segunda parte
            Tempera tempera1 = new Tempera(ConsoleColor.Red,"Alba",50);
            Tempera tempera2 = new Tempera(ConsoleColor.Blue, "Alba",50);
            Tempera tempera3 = new Tempera(ConsoleColor.Red, "Alba",25);
            Tempera tempera4 = new Tempera(ConsoleColor.Black, "Pinturita", 50);
            Tempera tempera5 = new Tempera(ConsoleColor.Black, "Alba", 50);

            /*Console.WriteLine("----- Compara color y marcar -----\n");
            Console.WriteLine(tempera1 == tempera2);
            Console.WriteLine(tempera1 == tempera3);
            Console.WriteLine(tempera1 == tempera4);
            Console.WriteLine(tempera1 == null); //me tira error en ejecucion 
            Console.WriteLine(null == tempera1); //me tira error en ejecucion 

            Console.WriteLine("\n----- Compara si las dos temperas son iguales -----\n");
            Console.WriteLine(tempera1 + tempera2);
            Console.WriteLine(tempera1 + tempera3);
            Console.WriteLine(tempera1 + tempera4);
            Console.WriteLine(tempera1 + null); //me tira error en ejecucion 

            Console.WriteLine("----- Al atributo cantidad del objeto de las Temperas se le suma -----\n");
            Console.WriteLine(tempera1 + 20);
            Console.WriteLine(tempera2 + 30);

            Console.WriteLine("----- Muestra Informacion de las temperas -----\n");

            Console.WriteLine(Tempera.Mostrar(tempera1));
            Console.WriteLine(Tempera.Mostrar(tempera2));
            Console.WriteLine(Tempera.Mostrar(tempera3));
            Console.WriteLine(Tempera.Mostrar(tempera4));
            */
            //Cuarta Parte

            //Máximo 3 temperas
            Console.WriteLine("primera lista\n");
            Paleta nuevaPaleta = 3;

            //Comparar(paleta - tempera)
            Console.WriteLine(nuevaPaleta == tempera1);

            //Sumar(paleta - tempera)
            Console.WriteLine("---------Suma--------------");
            nuevaPaleta = nuevaPaleta + tempera1;
            nuevaPaleta = nuevaPaleta + tempera2;
            //nuevaPaleta = nuevaPaleta + tempera3;
            //nuevaPaleta = nuevaPaleta + tempera4;
            //nuevaPaleta = nuevaPaleta + tempera5;
            Console.WriteLine((string)nuevaPaleta);

            //Restar (paleta - tempera)
            Console.WriteLine("---------Resta--------------");
            nuevaPaleta = nuevaPaleta - tempera1;
            nuevaPaleta = nuevaPaleta - tempera2;
           // nuevaPaleta = nuevaPaleta - tempera5;
            Console.WriteLine((string)nuevaPaleta);

            //Creamos otra paleta maximo 2
            Console.WriteLine("segunda lista\n");
            Paleta otraPaleta = 2; 

            //Sumar(paleta - tempera)
            otraPaleta = otraPaleta + tempera5;
            otraPaleta = otraPaleta + tempera4;
            //otraPaleta = otraPaleta + tempera3;
            //otraPaleta = otraPaleta + tempera2;
            Console.WriteLine((string)otraPaleta);

            //Sumar(paleta - paleta)
            Console.WriteLine("lista unidas\n");
            otraPaleta = otraPaleta + nuevaPaleta;
            Console.WriteLine((string)otraPaleta);


            Tempera auxTempera = otraPaleta[0];
            Console.WriteLine(Tempera.Mostrar(auxTempera));

            //Console.WriteLine(otraPaleta[-5]);
            //Console.WriteLine(otraPaleta[55]);
            Console.WriteLine("Agrego una paleta a la posicion 0");
            otraPaleta[0] = new Tempera(ConsoleColor.Blue, "Bic", 100);
            Console.WriteLine(Tempera.Mostrar(otraPaleta[0]));

            Console.ReadLine();
        }
    }
}
