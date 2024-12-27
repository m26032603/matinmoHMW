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
            // یک عدد از ورودی بگیرد و چک کند اول هست یا نه.
            int num, i = 2;
            string res = "prim";

            Console.WriteLine("Please enter 1 num:");

            num = int.Parse(Console.ReadLine());

            while (i < num)
            {
                if (num % i == 0)
                {
                    res = "not prim";
                    break;
                }
                i++;
            }

            Console.WriteLine("The num is " + res);
            Console.WriteLine("press any key to exit...");
            Console.ReadKey();
        }
    }
}