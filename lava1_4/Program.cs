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
            if (m < 0)
            {
                Console.WriteLine("Нельзя вводить значение, меньше нуля");
            }

            for (int x = 0; x < m; x++)
            {
                int e = 1;
                for (int n=0;n<=x;n++)
                {
                    for(int c=0;c<m-n;c++)
                    {
                        Console.Write(' ');
                    }
                    for (int c = 0; c < e; c++)
                    {
                        Console.Write('*');
                       
                    }
                    e+=2; Console.WriteLine();
                    
                }

            }   

            Console.ReadLine();
        }
    }
}
