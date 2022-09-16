using System;

namespace laba1_6
{
    class Program
    {
        static void Main(string[] args)
        {
            double a,b, c,p, S=0;
            Console.WriteLine("Введите значение а: ");
            while (!double.TryParse(Console.ReadLine(), out a)|| a <= 0)
            {
                Console.WriteLine("Не верный ввод данных");
            }
            Console.WriteLine("Введите значение b: ");
            while (!double.TryParse(Console.ReadLine(), out b) || b <= 0)
            {
                Console.WriteLine("Не верный ввод данных");
            }
            Console.WriteLine("Введите значение c: ");
            while (!double.TryParse(Console.ReadLine(), out c) || c <= 0)
            {
                Console.WriteLine("Не верный ввод данных");
            }
            if ((a + b > c) && (a + c > b) && (b + c > a))
            {
                p = (a + b + c) / 2;
                S = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
                Console.WriteLine("S== " + S);
            }
            
            else
            {
                Console.WriteLine("Треугольник не существует");
            }
            Console.ReadLine();

        }
    }
}
