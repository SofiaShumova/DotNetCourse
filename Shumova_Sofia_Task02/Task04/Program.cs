using System;

namespace Task04
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Введите кол-во треугольников:");
            string str = "*";

            int n = int.Parse(Console.ReadLine());
            for (int k = 0; k <= n; k++)
            {
                for (int j = 0; j < k; j++)
                {
                    for (int i = 1; i <= (n - j); i++)
                    {
                        Console.Write(" ");
                    }

                    Console.Write(str);
                    str += "**";
                    Console.WriteLine();
                }
                str = "*";

            }
        }
    }
}
