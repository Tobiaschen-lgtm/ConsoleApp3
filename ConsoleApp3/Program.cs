using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            int zahl;

            Console.WriteLine("Eine Zahl eingeben:");
            zahl = Convert.ToInt32(Console.ReadLine());

            //if (zahl % 2 == 0)
            if (zahl > 10)
            {
                //Console.WriteLine(zahl + " ist eine gerade Zahl.");
                Console.WriteLine(zahl + "ist größer als 10.");
            }
            else if (zahl == 10)
            {
                //Console.WriteLine(zahl + " ist eine ungerade Zahl.");
                Console.WriteLine(zahl + " ist gleich 10.");
            }
            else
            {
                Console.WriteLine(zahl + "ist kleiner als 10.");
            }



        }
    }
}


