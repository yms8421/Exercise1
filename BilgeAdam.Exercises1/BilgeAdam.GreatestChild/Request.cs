using System;
using System.Collections.Generic;
using System.Text;

namespace BilgeAdam.GreatestChild
{
    class ConsoleRequest
    {
        public string message;
        public static int GetNumber(string message)
        {
            Console.Write(message);
            var value = Console.ReadLine();
            while (true)
            {
                var success = int.TryParse(value, out int number);
                if (success)
                {
                    return number;
                }
                else
                {
                    Console.Write(message);
                    value = Console.ReadLine();
                }
            }
        }

        public static string GetText(string message, short minimumLength)
        {
            Console.Write(message);
            var value = Console.ReadLine();
            while (true)
            {
                if (value.Length >= minimumLength)
                {
                    return value;
                }
                Console.Write(message);
                value = Console.ReadLine();
            }
        }
    }
}
