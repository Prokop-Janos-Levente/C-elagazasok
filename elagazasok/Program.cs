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

            //3. feladat
            Console.WriteLine("Adj meg egy hónapszámot (1-12): ");
            int honap = int.Parse(Console.ReadLine());
            if ( honap>= 3 && honap <= 5)
                Console.WriteLine("Tavasz");
            else if (honap >= 6 && honap <= 8)
                Console.WriteLine("Nyár");
            else if (honap >= 9 && honap <= 11)
                Console.WriteLine("Ősz");
            else
                Console.WriteLine("Tél");
            Console.WriteLine();

            //4. feladat
            Console.WriteLine("Add meg az életkorod: ");
            int kor = int.Parse(Console.ReadLine());
            if (kor >= 18)
                Console.WriteLine("Már szavazhatsz.");
            else
                Console.WriteLine("mmég nem szavhatsz.");

        }
    }
}
