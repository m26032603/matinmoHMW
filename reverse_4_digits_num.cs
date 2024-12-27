using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // یک عدد چهار رقمی گرفته و آن را برعکس کند
            int num, a, b, c, d, result;

            Console.WriteLine("Please enter a 4 digit num:");
            num = int.Parse(Console.ReadLine());

            // Validation for 4 digit num
            while (num < 999)
            {
                Console.WriteLine("Please enter a 4 digit num:");
                num = int.Parse(Console.ReadLine());
            }

            d = num % 10;
            num = num / 10;
            c = num % 10;
            num = num / 10;
            b = num % 10;
            a = num / 10;

            result = (d * 1000) + (c * 100) + (b * 10) + a;

            Console.WriteLine("The result is: " + result);
            Console.WriteLine("press any key to exit...");
            Console.ReadKey();
        }
    }
}