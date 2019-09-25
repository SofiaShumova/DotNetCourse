using System;

namespace Task02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Исходный массив:");

            Random rand = new Random();
            int n = 5;
            int[,,] array = new int[n,n,n];

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    for (int k = 0; k < n; k++)
                    {
                        array[i, j, k] = rand.Next(-10, 10);
                        Console.Write(String.Format("{0,4} ", array[i, j,k]));
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();               
            }

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Положительные числа заменены на 0:");



            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    for (int k = 0; k < n; k++)
                    {
                        if (array[i, j, k] > 0)
                        {
                            array[i, j, k] = 0;
                        }
                        Console.Write(String.Format("{0,4} ", array[i, j, k]));
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
            }


            Console.ReadKey();
        }
    }
}
