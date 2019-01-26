using System;

namespace BilgeAdam.ConditionalSummary
{
    class Program
    {
        static void Main(string[] args)
        {
            var index = 0;
            var summary = 0;
            var first = 0;
            while (true)
            {
                Console.Write(++index + ". Sayı Giriniz.........: ");
                var number = int.Parse(Console.ReadLine());
                if (number > first)
                {
                    summary += number;
                    first = number;
                }
                //else
                //{
                //    continue;
                //}
                Console.WriteLine("Sayıların Toplamı....: {0}", summary);
            }
        }
    }
}



/*
 HAP:

    4 % 3 = 1 
    7 % 9 = 7
    10 % 2 = 0
    24 % 8 = 0
    131 % 7 = x
    || && > < != ==, %
    var a = 14;
    if(a % 4 == 0)
    {
        // bu işi yap
    }
*/