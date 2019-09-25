using System;

namespace Task03
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 10, sum=0;
            Random rand = new Random();
            int[] array = new int[n];

            Console.Write("Исходный массив: ");

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rand.Next(-10,10);
                if(array[i]>0)
                {
                    sum += array[i];
                }
                Console.Write( array[i]+ " ");
            }

            Console.WriteLine();
            Console.WriteLine("Сумма неотрицательных чисел равна="+sum);


            Console.ReadKey();
        }
    }
}
