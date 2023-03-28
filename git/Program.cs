using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace git
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите а");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите b");
            int b = Convert.ToInt32(Console.ReadLine());
           
            int sum =  a + b;
            Console.WriteLine($"SUM {sum}");

            int del = a / b;
            Console.WriteLine($"del {del}");

        }
    }
}
