using System;

namespace task12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //4 dene 6 reqemli eded verilib.
            //Ededlerin hamisinin 10 faizini tap ve topla.
            //Sonra hamisinin 15 faizini tap ve topla.
            //Sonra yekunda alinanlar iki cavabi vur biri birine.
            //Alinan neticenin evvel 10 % tap sonra ise hemin cavabin 11 % tap.
            double a = 100000;
            double b = 100000;
            double c = 100000;
            double d = 123456;
            double sum10;
            double sum15;
            double sum;

            if (a < 100000 || a >= 1000000 || b < 100000 || b >= 1000000 || c < 100000 || c >= 1000000 || d < 100000 || d >= 1000000)
            {

                Console.WriteLine("6 reqemli deyil");
                return;
            }

            // ededlerin 10%
            double a2 = a / 100 * 10;
            double b2 = b / 100 * 10;
            double c2 = c / 100 * 10;
            double d2 = d / 100 * 10;
            sum10 = a2 + b2 + c2 + d2;
            //ededlerin 15%
            double a1 = a / 100 * 15;
            double b1 = b / 100 * 15;
            double c1 = c / 100 * 15;
            double d1 = d / 100 * 15;
            sum15 = a1 + b1 + c1 + d1;
            sum = sum10 * sum15;
            sum = sum / 100 * 10;
            sum = sum / 100 * 11;
            Console.WriteLine(sum);
        }
    }
}
