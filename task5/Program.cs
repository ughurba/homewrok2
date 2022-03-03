using System;

namespace task5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 5) 3 reqemli eded verilib.
            //Bu ededin axirina 7 artir.
            //Sonra cavabin 7 % tap;
            Console.WriteLine("3 reqemli ededi qeyd eliyin");
            double a = Convert.ToDouble(Console.ReadLine());
            if (a < 100 || a >= 1000)
            {
                Console.WriteLine("3 reqemli deyil");
                return;
            }
            a = a * 10 + 7;
            a = a / 100 * 7;
            Console.WriteLine($" = {a}");
        }
    }
}
