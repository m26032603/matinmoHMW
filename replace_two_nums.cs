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
            // دو عدد از ورودی بگیرد و آن ها را جابجا کند.
            int a, b, temp;

            Console.WriteLine("Please enter 2 nums:");

            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());

            temp = a;
            a = b;
            b = temp;

            Console.WriteLine(" a is: " + a + " | b is: " + b);
            Console.WriteLine("press any key to exit...");
            Console.ReadKey();
        }
    }
}