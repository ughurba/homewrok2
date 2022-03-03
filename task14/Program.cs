using System;

namespace task14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 14) 6 dene 6 reqemli eded verilib.
            // Evvel hamisini topla.
            // Sonra I ve III ededi bir birine yapishdir ve bir eded al.
            //I neticeden II neticeni cix.
            //Alinan cavabin 10 % tap.
            //Neticenin uzerine V ve VI ededleri gel.
            //Yekunda alinan cavabin 11 % tap.
            double a = 123456;
            double b = 123456;
            double c = 123456;
            double d = 123456;
            double e = 123456;
            double j = 123456;
            double sum;
            if (a < 100000 || a >= 1000000)
            {
                Console.WriteLine("A 6 reqemli eded deyil");
                return;
            }
            else if (b < 100000 || b >= 1000000)
            {
                Console.WriteLine("B 6 reqemli eded deyil");
                return;

            }
            else if (c < 100000 || c >= 1000000)
            {
                Console.WriteLine("C 6 reqemli eded deyil");
                return;

            }
            else if (d < 100000 || d >= 1000000)
            {
                Console.WriteLine("D 6 reqemli eded deyil ");
                return;
            }
            else if (e < 100000 || e >= 1000000)
            {
                Console.WriteLine("E 6 REQEMLI EDED DEYIL");
                return;
            }
            else if (j < 100000 || j >= 1000000)
            {
                Console.WriteLine("J 6 reqemli eded deyil");
                return;
            }


            sum = a + b + c + d + e + j;
            double sum1 = a * 1000000 + c;
            double sum2 = sum - sum1;
            sum2 = sum2 / 100 * 10;
            sum2 = sum2 + e + j;
            sum2 = sum2 / 100 * 11;
            Console.WriteLine(sum2);
        }
    }
}
