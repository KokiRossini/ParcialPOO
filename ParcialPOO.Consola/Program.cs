using ParcialPOO.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParcialPOO.Consola
{
    class Program
    {
        static void Main(string[] args)
        {
            Fecha f = new Fecha();
            Fecha f2 = new Fecha(1, 2, 3);
            Fecha f3 = new Fecha(1, 2, 3);
            Fecha f4 = "14/06/2003";
            if (f2.Validar())
            {
                Console.WriteLine("Fecha Valida");
                Console.WriteLine(f2.MostrarFecha());
                Console.WriteLine(f2.MostrarFechaConMes());

            }
            else
            {
                Console.WriteLine("Fecha no valida");
            }

            if (f2==f3)
            {
                Console.WriteLine("Son iguales");
            }
            else
            {
                Console.WriteLine("Son Diferentes");
            }

            Console.WriteLine(f.MostrarFecha());
            Console.WriteLine(f.MostrarFechaConMes());

            Console.WriteLine("Implicito");
            Console.WriteLine(f4.MostrarFechaConMes());



            Console.ReadLine();
        }
    }
}
