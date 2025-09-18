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
            Console.WriteLine();

            //5. feladat
            Console.WriteLine("Add meg a jegyet (1-5): ");
            int jegy = int.Parse(Console.ReadLine());
            if (jegy < 3)
                Console.WriteLine("Elégtelen");
            else if (jegy == 3)
                Console.WriteLine("Elégséges");
            else if (jegy == 4)
                Console.WriteLine("Jó");
            else
                Console.WriteLine("Jeles");
            Console.WriteLine();

            //6. feladat
            Console.WriteLine("Gondoltam egy számra. Próbáld kitalálni.");
            int kitalal = int.Parse(Console.ReadLine());
            int kitalalt = 15;

            if (kitalal == kitalalt)
                Console.WriteLine("Gratulálok eltaláltad.");
            else if (kitalal > kitalalt)
                Console.WriteLine("A szám amire gondoltam kisebb.");
            else
                Console.WriteLine("A szám amire gondoltam nagybb.");
            Console.WriteLine();

            //7.feladat
            Console.WriteLine("adj meg egy számot: ");
            int jo = int.Parse(Console.ReadLine());
            if (jo > 0 && jo % 2 == 0)
                Console.WriteLine("A szám pozitív és páros.");
            else
                Console.WriteLine("A szám nem pozitív és páros.");

            //8. feladat
            Console.WriteLine("Adj meg egy karaktert: ");
            char karakter = Console.ReadKey().KeyChar;
            if (char.IsDigit(karakter))
                Console.WriteLine("Ez egy szám.");
            else if (char.IsLetter(karakter))
                Console.WriteLine("Ez egy betű.");
            else
                Console.WriteLine("Ez sem szám sem betű.");

            //9. feladat
            string jelszo = "titok123";
            Console.WriteLine("Add meg a jelszót: ");
            string kitalalas = Console.ReadLine();
            if (kitalalas == jelszo)
                Console.WriteLine("Helyes jelszó.");
            else
                Console.WriteLine("Helytelen jelszó");

            //10. feladat
            Console.Write("Kérlek, add meg az első számot: ");
            int num1 = int.Parse(Console.ReadLine());

            Console.Write("Kérlek, add meg a második számot: ");
            int num2 = int.Parse(Console.ReadLine());

            Console.Write("Kérlek, add meg a harmadik számot: ");
            int num3 = int.Parse(Console.ReadLine());

            int nagyobb = num1;

            if (num2 > nagyobb)
            {
                nagyobb = num2;
            }

            if (num3 > nagyobb)
            {
                nagyobb = num3;
            }

            Console.WriteLine($"A legnagyobb szám: {nagyobb}");
        }
    }
}
