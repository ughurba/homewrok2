using System;

namespace task10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //4 reqemli eded verilib.
            //Bu ededin evvel 20%-ni ,
            //sonra ise cavabin 10% tap.
            //Alinan cavabin kvadratini tap.
            double a = 1234;

            if (a >= 1000 && a < 10000)
            {
                a = a / 100 * 20;
                a = a / 100 * 10;
                a = a * a;
                Console.WriteLine(a);
            }
            else
            {
                Console.WriteLine(" bu eded 4 reqemli eded deyil");
            }
        }
    }
}
