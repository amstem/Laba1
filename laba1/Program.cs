using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace laba1
{
    class Program
    {
        

        static void Main(string[] args)
        {
            int a;
            Console.WriteLine("Введите сторону a: ");
            while (!int.TryParse(Console.ReadLine(), out a))
            {
                Console.WriteLine("Можно вводить только целые числа");
            }

            int b;
            Console.WriteLine("Введите сторону b:  ");
            while (!int.TryParse(Console.ReadLine(), out b))
            {
                Console.WriteLine("Можно вводить только целые числа");
            }
            int qw = -1;
            int m = a * b;
            if (m < 0)
            {
                int c = m * qw;
                Console.WriteLine(c);
            }
            else
            Console.WriteLine(m);
            Console.ReadKey();

        }
    }
}
