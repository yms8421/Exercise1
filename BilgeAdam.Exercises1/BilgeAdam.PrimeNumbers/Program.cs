using System;
using System.Diagnostics;

namespace BilgeAdam.PrimeNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            //2, 3, 5, 7, 11, 13, 17, 19 ....
            var exception = 2;
            Console.Write(exception);
            for (var number = 3; number < 100; number++)
            {
                var half = number / 2;
                var isDivided = false;
                for (var d = 2; d < half; d++)
                {
                    if (number % d == 0)
                    {
                        isDivided = true;
                        break;
                    }
                }
                if (!isDivided)
                {
                    Console.Write(" - {0}", number);
                }
            }
            Console.ReadLine();
        }
    }
}
