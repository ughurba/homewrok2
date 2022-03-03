using System;

namespace task7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 2 dene eded verilib.
            //I eded 4 reqemli II eded 7 reqemlidir.
            //I ededin 4 % -ni tap.
            //Sonra II ededin 9 % ni tap.
            //Sonra Cavalari toplayib 10 % ni tap.

            double a = 1234;
            double b = 1234567;

            if (a < 1000 || a >= 10000 || b < 1000000 || b >= 10000000)
            {
                Console.WriteLine("yazdiqiniz 4 ve ya 7 reqemli eded deyil");
                return;
            }

            a = a / 100 * 4;
            Console.WriteLine($"birinci ededin 4% = {a}");
            b = b / 100 * 9;
            Console.WriteLine($"ikinci ededin 9% = {b}");
            double c = (a + b) / 100 * 10;
            Console.WriteLine($"birinci ve ikinci ededlerin toplanmiw 10 % ise = {c}");
        }
    }
}
