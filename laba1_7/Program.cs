using System;

namespace laba1_7
{
    class Program
    {
        static void Main(string[] args)
        {
            byte a,b;
            Console.WriteLine("Введите значение a: ");
            while (!byte.TryParse(Console.ReadLine(), out a) || a < 0)
            {
                Console.WriteLine("Не верный ввод данных");
            }
            Console.WriteLine("Введите значение b: ");
            while (!byte.TryParse(Console.ReadLine(), out b) || b < 0)
            {
                Console.WriteLine("Не верный ввод данных");
            }
            Console.WriteLine("«побитовое И» == " + (a & b));
            Console.WriteLine("«побитовое ИЛИ» == " + (a | b));
            Console.WriteLine("«побитовое исключающее ИЛИ» == " + (a ^ b));
            Console.ReadLine();

        }
    }
}
