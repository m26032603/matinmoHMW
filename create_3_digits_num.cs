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
            // سه عدد از کاربر گرفته و مانند ماشین حساب اعداد را به ترتیب ورود به صورت یک عدد سه رقمی چاپ کند.
            int a, b, c, result = 0;

            Console.WriteLine("Please enter 3 nums with 1 digit:");

            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            c = int.Parse(Console.ReadLine());

            // Validation for 1 digit nums
            while (!(0 < a && a < 10 && 0 <= b && b < 10 && 0 <= c && c < 10))
            {
                Console.WriteLine("Please enter 3 nums with 1 digit:");
                a = int.Parse(Console.ReadLine());
                b = int.Parse(Console.ReadLine());
                c = int.Parse(Console.ReadLine());
            }

            result = (a * 100) + (b * 10) + c;

            Console.WriteLine("The result is: " + result);
            Console.WriteLine("press any key to exit...");
            Console.ReadKey();
        }
    }
}