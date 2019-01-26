using System;

namespace BilgeAdam.Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            var first = 0;
            var second = 1;
            Console.Write("{0} - {1}", first, second);
            var third = 0;
            while (true)
            {
                third = first + second;
                if (third > 200)
                {
                    break;
                }
                Console.Write(" - {0}", third);
                //sayıları kaydır
                first = second;
                second = third;
            }

            Console.ReadLine();
        }
    }
}
