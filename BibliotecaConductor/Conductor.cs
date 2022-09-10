using System;
using System.Text;

namespace BibliotecaConductor
{
    public class Conductor
    {
        private string nombre;
        private  int[] kilometros = new int[7];
        
        public Conductor(string nombre, int[] kilometros)
        {
            this.nombre = nombre;
            this.kilometros = kilometros;
        }

        public int[] Kilometros
        {
            get
            {
                return this.kilometros;
            }
        }

        public string Nombre
        {
            get
            {
                return this.nombre;
            }
        }

        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Nombre del conductor: {this.nombre}");
            sb.AppendLine($"Kilometros recorrido por cada dia de la semana: ");

            for (int i = 0; i < 7; i++)
            {
                sb.AppendLine($"Dia {i+1}: {this.kilometros[i]} km");
            }

            return sb.ToString();
        }

        //Acumula la cantidad de km recorridos en la semana.
        public int CantidadKmEnLaSemana()
        {
            int acumuladorKmSemana = 0;

            foreach (int kmDia in kilometros) //array de tipo int 
            {
                acumuladorKmSemana += kmDia; //Por cada dia va acumulando los km.
            }

            return acumuladorKmSemana;
        }

        public string ConductorMasKmSemana(Conductor[] aConductores) //array de tipo conductor que almacena datos de los conductores
        {
            int kmEnLaSemana = 0;
            int maximoKmSemana = 0;
            string nombreConductor = ""; //si o si tuve que inicializarlo me daba error en el return
            int flag = 0;

            foreach (Conductor unConductor in aConductores)
            {
                kmEnLaSemana = unConductor.CantidadKmEnLaSemana();

                if (flag == 0 || kmEnLaSemana > maximoKmSemana) //En la primera iteracion flag == 0 es true entonces NO se fija en la segunda condicion
                {
                    maximoKmSemana = kmEnLaSemana;
                    nombreConductor = unConductor.Nombre; //llama al getter para tener obtener el dato
                    flag = 1; //cambio el valor, flag == 0 es false, en la segunda iteracion se fija entonces en la segunda condicion
                }

            }

            return nombreConductor;
        }

        public string ConductorMasKmDia3(Conductor[] aConductores) //Nombre del array aConductores, tipo Conductor
        {
            int kmDiaTres = 0;
            int maximoKmDia = 0;
            string nombreConductor = "";
            int flag = 0;

            foreach (Conductor unConductor in aConductores)
            {
                kmDiaTres = unConductor.kilometros[2]; //unConductor es del mismo tipo que el array aConductores
                //por eso que atraves de esa objeto accedo al array kilometros

                if (flag == 0 || kmDiaTres > maximoKmDia)
                {
                    maximoKmDia = kmDiaTres;
                    nombreConductor = unConductor.Nombre;
                    flag = 1;
                }

            }
            return nombreConductor;
        }

        public string ConductorMasKmDia5(Conductor[] aConductores) //Nombre del array aConductores, tipo Conductor
        {
            int kmDiaCinco = 0;
            int maximoKmDia = 0;
            string nombreConductor = "";
            int flag = 0;

            foreach (Conductor unConductor in aConductores)
            {
                kmDiaCinco = unConductor.kilometros[4]; //unConductor es del mismo tipo que el array aConductores
                //por eso que atraves de esa objeto accedo al array kilometros

                if (flag == 0 || kmDiaCinco > maximoKmDia)
                {
                    maximoKmDia = kmDiaCinco;
                    nombreConductor = unConductor.Nombre;
                    flag = 1;
                }

            }
            return nombreConductor;
        }
    }  
}
