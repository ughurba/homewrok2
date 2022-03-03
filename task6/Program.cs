using System;

namespace task6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //2 dene 5 reqemli eded verilib.
            //Bu ededleri toplayib.
            //Alinan cavabin evveline ve axirina 5 artir.
            //Neticenin 5 % tap



            Console.WriteLine(" birinic 5 reqemli ededi qeyd eliyin");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("ikinci 5 reqemli ededi qeyd eliyin");
            double b = Convert.ToDouble(Console.ReadLine());
            if (a < 10000 || a >= 100000 || b < 10000 || b >= 100000)
            {
                Console.WriteLine("yazdiqiniz eded 5 reqemli eded deyil");
                return;
            }

            double c = (a + b + 500000) * 10 + 5;
            Console.WriteLine($"= {c} bu ededin 5% awaqida gorsenir");
            c = c / 100 * 5;
            Console.WriteLine($"= {c}");
        }
    }
}
