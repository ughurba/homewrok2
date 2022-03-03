using System;

namespace task15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 7 dene eded verilib.
            // Bunlardan 2 denesi 3 reqemlidir.
            // 2 denesi 4 reqemlidir.
            // 2 denesi 5 reqemlidir.
            // 1 denesi ise 6 reqemlidir.
            //3 reqemli ededleri topla ,
            //sonra bunlarin ustune gel 4 reqemli ededlerin bir birine vurulmasindan alinan cavabi.
            //Sonra neticenin axirina 7 reqemini artir.
            //Sonra cavabin ustune gel 5 reqemli ededlerin cemini.
            //Sonra neticeden cix 3 reqemli ededlerin bir birine vurulmasindan alinan cavabin axirina 1 artirilmish variantini.
            //Sonra alinan cavabin ustune gel 6 reqemli ededi.
            //Sonra alinan  ccavabdan cix 3 reqemli ve 4 reqemli ededlerin cemini.
            //Sonra alinan cavabin 18 % -ni sonra 3 % -ni sonra 1 % tap.
            //Sonra alinan cavabin ustune 5 reqemli ededlerin cemini gel.


            Console.Write("1-nci 3 reqemli ededi daxil edin:");
            double num1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("2-nci 3 reqemli ededi daxil edin:");
            double num2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("1-nci 4 reqemli ededi daxil edin:");
            double num3 = Convert.ToDouble(Console.ReadLine());
            Console.Write("2-nci 4 reqemli ededi daxil edin:");
            double num4 = Convert.ToDouble(Console.ReadLine());
            Console.Write("1-nci 5 reqemli ededi daxil edin:");
            double num5 = Convert.ToDouble(Console.ReadLine());
            Console.Write("2-nci 5 reqemli ededi daxil edin:");
            double num6 = Convert.ToDouble(Console.ReadLine());
            Console.Write("6 reqemli ededi daxil edin:");
            double num7 = Convert.ToDouble(Console.ReadLine());


            if (num1 < 100 || num1 >= 1000 || num2 < 100 || num2 >= 1000)
            {
                Console.WriteLine("1-ci ve 2-ci eded 3 reqemli eded deyil");
                return;
            }

            else if (num3 < 1000 || num3 >= 10000 || num4 < 1000 || num4 >= 10000)
            {
                Console.WriteLine("1-ci ve 2-ci eded 4 reqemli eded deyil");
                return;
            }

            else if (num5 < 10000 || num5 >= 100000 || num6 < 10000 || num6 >= 100000)
            {
                Console.WriteLine("1-ci ve 2-ci eded 5 reqemli eded deyil");
                return;
            }

            else if (num7 < 100000 || num7 >= 10000000)
            {
                Console.WriteLine("6 reqemli eded deyil");
                return;
            }

            double ucReqemliEdedler = num1 + num2;
            double dordReqemliEdedler = num3 * num4;

            double sum = ucReqemliEdedler + dordReqemliEdedler;
            sum = sum * 10 + 7;

            double besReqemliEdedler = num5 + num6;
            sum = sum + besReqemliEdedler;

            double ucReqemliededVurulmasi = num1 * num2;
            ucReqemliededVurulmasi = ucReqemliededVurulmasi * 10 + 1;

            sum = sum - ucReqemliededVurulmasi;
            sum = sum + num7;

            double ucVeDordReqemler = num1 + num2 + num3 + num4;
            sum = sum - ucVeDordReqemler;

            sum = sum / 100 * 18;
            sum = sum / 100 * 3;
            sum = sum / 100 * 1;

            sum = sum + besReqemliEdedler;
            Console.WriteLine(sum);
        }
    }
}
