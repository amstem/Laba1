using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba_1_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int m = 0;
            Console.WriteLine("Введите значение: ");
            while (!int.TryParse(Console.ReadLine(), out m))
            {
                Console.WriteLine("Можно вводить только целые числа");
            }
            if (m<0)
            {
                Console.WriteLine("Нельзя вводить значение, меньше нуля");
            }
            

            for (int i = m; i > 0; i--)
            {
                for (int j = m - i; j < m; j++)
                {
                    Console.Write(" ");
                }
                for (int j = 0; j < m - i; j++)
                {
                    Console.Write("*");
                }
                for (int j = 0; j < m - i+1; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            Console.ReadKey();
        }


    }
    
}