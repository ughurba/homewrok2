using System;

namespace task11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //4 dene 5 reqemli eded verilib.
            //Her I ededin ustune III ededi gel .
            //II ededin usutune IV eeddi gel.
            //Sonra cavablari vur birbirine.
            //Alinan neticeden III ededin 3 % -ni cix.

            double a = 10000;
            double b = 10000;
            double c = 11111;
            double d = 10000;
            double sum;
            double e;


            if (a < 10000 || a >= 100000 || b < 10000 || b >= 100000 || c < 10000 || c >= 100000 || d < 10000 || d >= 100000)
            {
                Console.WriteLine("5 reqemli eded deyil");
                return;
            }
            e = c / 100 * 3;
            a = a + c;
            b = b + d;
            sum = a * b;
            sum = sum - e;

            Console.WriteLine(sum);
        }
    }
}
