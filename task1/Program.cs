using System;

namespace task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1) 4 reqemli eded verilib. 
            //Bu ededin eveline 7 reqemini ,
            //axirinada 8 reqemini artir.
            //Example1: 333= 73338

            int a = 1000;

            if (a < 1000 || a >= 10000)
            {

                Console.WriteLine("4 reqemli deyil");
                return;
            }
            int b = a + 70000;
            b = b * 10 + 8;
            Console.WriteLine(b);
            Console.WriteLine("good");
        }
    }
}
