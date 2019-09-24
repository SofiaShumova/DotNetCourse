using System;

namespace Task02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Рисунок");
            Console.Write("Введите число:");
            int n = int.Parse(Console.ReadLine());
            for (int j = 0; j <= n; j++)
            {
                for (int i = 0; i < j; i++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}
