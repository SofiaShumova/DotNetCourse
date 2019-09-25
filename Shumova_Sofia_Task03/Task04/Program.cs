using System;

namespace Task04
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 5, sum = 0;
            Random rand = new Random();
            int[,] array = new int[n,n];

            Console.WriteLine("Исходный массив: ");

            for (int i = 0; i <n; i++)
            {
                for (int j=0; j<n; j++)
                {
                    array[i,j] = rand.Next(10);
                    if ((i+j)%2==0)
                    {
                        sum += array[i,j];
                    }
                    Console.Write(String.Format("{0,3} ", array[i, j]));
                }

                Console.WriteLine();
            }

            Console.WriteLine();
            Console.WriteLine("Сумма элементов на четных позициях=" + sum);


            Console.ReadKey();
        }
    }
}
