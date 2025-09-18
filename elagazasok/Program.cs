using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace elagazasok
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1.feladat
            Console.Write("Adj meg egy szémot: ");
            int szam =  int.Parse(Console.ReadLine());
            if (szam % 2 == 0)
                Console.WriteLine("Páros");
            else
                Console.WriteLine("Páratlan");
            Console.ReadLine();

            //2.feladat
            Console.WriteLine("Adj meg egy számot: ");
            int szam1 = int.Parse(Console.ReadLine());
            if (szam1 > 0)
                Console.WriteLine("Pozitív");
            else if (szam1 < 0)
                Console.WriteLine("Negatív");
            else
                Console.WriteLine("Nulla");
            Console.ReadLine();

        }
    }
}
