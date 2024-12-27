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
            // دو عدد از ورودی گرفته و میانگین آن را چاپ کند
            float a;
            float b;
            float avg;

            Console.WriteLine("Please enter 2 nums");
            a = float.Parse(Console.ReadLine());
            b = float.Parse(Console.ReadLine());

            avg = (a + b) / 2;

            Console.WriteLine("The Average is: " + avg);
            Console.WriteLine("press any key to exit...");
            Console.ReadKey();
        }
    }
}