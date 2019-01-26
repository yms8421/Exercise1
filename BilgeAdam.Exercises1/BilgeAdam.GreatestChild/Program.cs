using System;

namespace BilgeAdam.GreatestChild
{
    class Program
    {
        static void Main(string[] args)
        {
            var summary = 0;
            var count = 3D;// ==> M var F var D var hangisi neydi? :D

            var greatestChild = "";
            var greatestChildAge = 0;
            for (int i = 0; i < count; i++)
            {
                var name = ConsoleRequest.GetText((i + 1) + ". Kardeşin Adını Giriniz........: ", 2);
                var age = ConsoleRequest.GetNumber((i + 1) + ". Kardeşin Yaşını Giriniz......: ");
                summary += age;

                if (age > greatestChildAge) // son girilen yaş en büyük yaştan büyükse
                {
                    greatestChildAge = age; //en büyük yaş son girilen yaş olsun
                    greatestChild = name; //en büyük kardeş son girilen isim olsun
                }
                Console.WriteLine();
            }

            var average = summary / count; 
            Console.WriteLine("{0} kardeşin yaş ortalaması.....: {1}", count, average);
            Console.WriteLine("En büyük kardeşin adı...........: {0}", greatestChild);

            Console.ReadLine();
        }
    }
}
