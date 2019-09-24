using System;

namespace Task03
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Рисунок 2");
            Console.Write("Введите количество строк:");
            int n = int.Parse(Console.ReadLine());
            string str = "*";
            for (int j = 0; j < n; j++)
            {
                for (int i = 1; i <= (n - j); i++)
                {
                    Console.Write(" ");
                }

                Console.Write(str);
                str += "**";
                Console.WriteLine();
            }
        }
    }
}
