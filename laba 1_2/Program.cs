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
            

            Console.WriteLine("Введите значение" );
            int m;
            while (!int.TryParse(Console.ReadLine(), out m))
            {
                Console.WriteLine("Можно вводить только целые числа");
            }
            for (int j=0;j<m;j++)
            {
                
                for (int o = 0; o < j; o++)
                {

                    Console.Write("*");
                }
                Console.WriteLine("*");
            }
            Console.ReadLine();
        }
    }
}
