using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstracciones
{
    class Program
    {
        static void Main(string[] args)
        {
            Auto objauto = new Auto(1987,"Ford","Falcon","Bordo","VTP 717");
              string resumen;
            //objauto.Marca = "Ford";
            //objauto.Modelo = "Falcon";
            //objauto.Anio = 1987;
            //objauto.Patente = "VTP 717";

             resumen =   objauto.get_resumen();
            objauto.Encender();
            objauto.Mover_metros();
            objauto.Apagar();


            Console.WriteLine(resumen);
            Console.ReadKey();



        }
    }
}
