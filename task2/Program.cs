using System;

namespace task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //2) 3 reqemli eded verilib.
            //Bu ededin axirina hemin ededdin ozunu yapishdir.
            //example: 333= 333333;

            int a = 333;
            if (a < 100 || a >= 1000)
            {
                Console.WriteLine("3 reqemli deyil");
                return;
            }
            int b = a * 1000;
            b = b + 333;
            Console.WriteLine($"b ==> {b}");
        }
    }
}
