using System;

namespace task8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 3 dene 6 reqemli eded verilib.
            // Her birinin 10 faizini tapib neticeleri topla.
            // Alinan cavabin 10% tap.

            double a = 123456;
            double b = 123456;
            double c = 123456;
            double cem;

            if (a < 100000 || a >= 1000000)
            {
                Console.WriteLine("A ededi 6 reqemli deyil");
                return;
            }
            else if (b < 100000 || b >= 1000000)
            {
                Console.WriteLine("B ededi 6 reqemli deyil");
                return;
            }
            else if (c < 100000 || c >= 1000000)
            {
                Console.WriteLine("C ededi 6 reqemli deyil");
                return;
            }

            a = a / 100 * 10;
            b = b / 100 * 10;
            c = c / 100 * 10;
            cem = a + b + c;
            cem = cem / 100 * 10;
            Console.WriteLine(cem);
        }
    }
}
