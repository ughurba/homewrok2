using System;

namespace task9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 3 dene 4 reqemli eded verilib.
            // I ededin 1 % -ni,
            // II ededin 2 % ,
            // III ededin 3 % tap.
            // Neticeleri bir birinden cix.
            // Alinan cavabin ustune III ededin 7 % faizini gel

            double a = 9432;
            double b = 9234;
            double c = 7654;
            double d;
            double cem;
            if (a < 1000 || a >= 10000 || b < 1000 || b >= 10000 || c < 1000 || c >= 10000)
            {
                Console.WriteLine(" 4 reqemli eded deyil");
                return;
            }

            a = a / 100 * 1;
            d = c / 100 * 7;
            b = b / 100 * 2;
            c = c / 100 * 3;
            cem = a - b - c;
            cem = cem + d;
            Console.WriteLine($"= {cem}");
        }
    }
}
