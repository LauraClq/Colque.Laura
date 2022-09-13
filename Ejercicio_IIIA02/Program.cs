using System;
using BibliotecaVeterinaria;

namespace Ejercicio_IIIA02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "La veterinaria";

            Mascotas mascota1 = new Mascotas("Perro","Ginger",new DateTime(2020,06,12));
            Mascotas[] aMascotaUno = {mascota1};
            Clientes cliente1 = new Clientes("Laura","Colque","Inclan 4567","4278-4738",aMascotaUno);

            Mascotas mascota2 = new Mascotas("Gato","Bonnie",new DateTime(2015,09,21));
            mascota2.AgregarVacuna("Triple Felina");
            Mascotas[] aMascotaDos = {mascota2};
            Clientes cliente2 = new Clientes("Sofia","Perez","Alberti 1244","2367-4538",aMascotaDos);

            Mascotas mascota3 = new Mascotas("Gato","Marty",new DateTime(2019,09,01));
            Mascotas mascota4 = new Mascotas("Perro","Loki",new DateTime(2010,03,12));
            mascota4.AgregarVacuna("Contra la rabia");
            Mascotas[] aMascotasTres = {mascota3,mascota4};
            Clientes cliente3 = new Clientes("Manuel", "Bustos", "Av Brasil 3456", "4348-4338", aMascotasTres);
            
            
            Console.WriteLine(cliente1.Mostrar());
            Console.WriteLine(cliente2.Mostrar());
            Console.WriteLine(cliente3.Mostrar());
            Console.ReadLine();
        }
    }
}
