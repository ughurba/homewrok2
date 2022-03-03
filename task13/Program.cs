using System;

namespace task13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //5 dene eded verilib.
            //Bunlardan 3 denesi 5 reqemli.
            //2 denesi ise 3 reqemlidir.
            //5 reqemli ededlerin 5% tap ,
            //neticeleri vur bir birine.
            // Sonra 3 reqemli ededlerin 3 % tap
            // ,neticeleri topla.
            // Sonra yekunda alinan iki cavalarin her birinin 10 % -ni tapib topla.

            double a = 10000;
            double b = 10000;
            double c = 10000;
            double d = 500;
            double e = 500;

            if (a < 10000 || a >= 100000 || b < 10000 || b >= 100000 || c < 10000 || c >= 100000)
            {
                Console.WriteLine("a , b ve c ededi 5 reqemli eded deyil");
                return;
            }
            else if (d < 100 || d >= 1000 || e < 100 || e >= 1000)
            {
                Console.WriteLine("d ve e ededi 3 reqemli deyil");
                return;
            }

            a = a / 100 * 5;
            b = b / 100 * 5;
            c = c / 100 * 5;
            double sum5 = a * b * c;

            d = d / 100 * 3;
            e = e / 100 * 3;
            double sum3 = d + e;
            sum5 = sum5 / 100 * 10;
            sum3 = sum3 / 100 * 10;
            double sum = sum5 + sum3;
            Console.WriteLine(sum);
        }
    }
}
