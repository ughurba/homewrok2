﻿using System;

namespace task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //3) 5 reqemli eded verilib.
            //Bu ededin evvel 18 % sonra ise 3 % tap.

            //pozitiv formasi
            double a, b;
        Step1:
            Console.Clear();
            Console.WriteLine("secim edin \n18% yoxsa 3%");
            int secim = Convert.ToInt32(Console.ReadLine());
            if (secim == 18)
            {
                Console.WriteLine("5 reqemli ededi daxil edin");
                a = Convert.ToDouble(Console.ReadLine());
                b = a / 100 * 18;
                Console.WriteLine($"= {b}");
            }
            else if (secim == 3)
            {
                Console.WriteLine("5 reqemli ededi daxil edin");
                a = Convert.ToDouble(Console.ReadLine());
                b = a / 100 * 3;
                Console.WriteLine($"= {b}");
            }
            else
            {
                Console.WriteLine("duzgun secim etmediniz");
                Console.ReadKey();
                goto Step1;

            }


            /*
                        //inkar formasi
                        double a, b;
                        Console.WriteLine("secim edin \n18% yoxsa 3%");
                        int secim = Convert.ToInt32(Console.ReadLine());

                        if ( secim != 18 && secim != 3)
                        {
                            Console.WriteLine("duzgun secim etmediniz");
                        }else if (secim == 18)
                        {

                            Console.WriteLine("5 reqemli ededi daxil edin");
                            a = Convert.ToDouble(Console.ReadLine());
                            b = a / 100 * 18;
                            Console.WriteLine($"= {b}");
                        }
                        else
                        {
                            Console.WriteLine("5 reqemli ededi daxil edin");
                            a = Convert.ToDouble(Console.ReadLine());
                            b = a / 100 * 3;
                            Console.WriteLine($"= {b}");
                        }
              */
        }
    }
}
