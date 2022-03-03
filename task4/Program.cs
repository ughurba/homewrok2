using System;

namespace task4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 4 reqemli eded verilib.
            //Bu ededin evvelin 4 reqemi ,
            //axirina ise 44 ededini artir.
            //Alinan cavabin 44 % tap.





            Console.WriteLine("4 reqemli eded qeyd eliyin");
            double a = Convert.ToDouble(Console.ReadLine());

            if (a >= 1000 && a < 10000)
            {
                a = (a + 40000) * 100 + 44;
                a = a / 100 * 44;
                Console.WriteLine($"= {a}");
            }
            else
            {
                Console.WriteLine("dord reqemli deyil");

            }
        }
    }
}
