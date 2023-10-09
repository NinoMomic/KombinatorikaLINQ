using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KonbinatorikaLINQ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] DevetoZnamenkastiBroj = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            var query =
                from Znamenka1 in DevetoZnamenkastiBroj
                from Znamenka2 in DevetoZnamenkastiBroj
                where Znamenka2 != Znamenka1
                   && (Znamenka1 * 10 + Znamenka2) % 2 == 0
                from Znamenka3 in DevetoZnamenkastiBroj
                where Znamenka3 != Znamenka2 && Znamenka3 != Znamenka1
                   && (Znamenka1 * 100 + Znamenka2 * 10 + Znamenka3) % 3 == 0
                from Znamenka4 in DevetoZnamenkastiBroj
                where Znamenka4 != Znamenka3 && Znamenka4 != Znamenka2 && Znamenka4 != Znamenka1
                   && (Znamenka1 * 1000 + Znamenka2 * 100 + Znamenka3 * 10 + Znamenka4) % 4 == 0
                from Znamenka5 in DevetoZnamenkastiBroj
                where Znamenka5 != Znamenka4 && Znamenka5 != Znamenka3 && Znamenka5 != Znamenka2 && Znamenka5 != Znamenka1
                   && (Znamenka1 * 10000 + Znamenka2 * 1000 + Znamenka3 * 100 + Znamenka4 * 10 + Znamenka5) % 5 == 0
                from Znamenka6 in DevetoZnamenkastiBroj
                where Znamenka6 != Znamenka5 && Znamenka6 != Znamenka4 && Znamenka6 != Znamenka3 && Znamenka6 != Znamenka2 && Znamenka6 != Znamenka1
                   && (Znamenka1 * 100000 + Znamenka2 * 10000 + Znamenka3 * 1000 + Znamenka4 * 100 + Znamenka5 * 10 + Znamenka6) % 6 == 0
                from Znamenka7 in DevetoZnamenkastiBroj
                where Znamenka7 != Znamenka6 && Znamenka7 != Znamenka5 && Znamenka7 != Znamenka4 && Znamenka7 != Znamenka3 && Znamenka7 != Znamenka2 && Znamenka7 != Znamenka1
                   && (Znamenka1 * 1000000 + Znamenka2 * 100000 + Znamenka3 * 10000 + Znamenka4 * 1000 + Znamenka5 * 100 + Znamenka6 * 10 + Znamenka7) % 7 == 0
                from Znamenka8 in DevetoZnamenkastiBroj
                where Znamenka8 != Znamenka7 && Znamenka8 != Znamenka6 && Znamenka8 != Znamenka5 && Znamenka8 != Znamenka4 && Znamenka8 != Znamenka3 && Znamenka8 != Znamenka2 && Znamenka8 != Znamenka1
                   && (Znamenka1 * 10000000 + Znamenka2 * 1000000 + Znamenka3 * 100000 + Znamenka4 * 10000 +
                       Znamenka5 * 1000 + Znamenka6 * 100 + Znamenka7 * 10 + Znamenka8) % 8 == 0
                from Znamenka9 in DevetoZnamenkastiBroj
                where Znamenka9 != Znamenka8 && Znamenka9 != Znamenka7 && Znamenka9 != Znamenka6 && Znamenka9 != Znamenka5 && Znamenka9 != Znamenka4 && Znamenka9 != Znamenka3 && Znamenka9 != Znamenka2 && Znamenka9 != Znamenka1
                let number = Znamenka1 * 100000000 +
                             Znamenka2 * 10000000 +
                             Znamenka3 * 1000000 +
                             Znamenka4 * 100000 +
                             Znamenka5 * 10000 +
                             Znamenka6 * 1000 +
                             Znamenka7 * 100 +
                             Znamenka8 * 10 +
                             Znamenka9 * 1
                where number % 9 == 0
                select number;

            foreach (int n in query)
                Console.WriteLine(n);

            Console.ReadKey();
        }
    }
}
