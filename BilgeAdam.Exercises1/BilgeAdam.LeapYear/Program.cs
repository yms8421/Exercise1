using System;

namespace BilgeAdam.LeapYear
{
    class Program
    {
        //CQRS: Command Query Responsibility Segregation
        static void Main(string[] args)
        {
            var currentYear = DateTime.Now.Year;
            var year = currentYear - 200;
            for (; year < currentYear; year++)
            {
                if (year % 100 == 0 && year % 400 != 0)
                {
                    continue;
                }
                if (year % 4 == 0)
                {
                    Console.WriteLine(year);
                }
            }
            Console.ReadLine();
        }
    }
}
