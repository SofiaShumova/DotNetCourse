using System;

namespace Task01
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 10;
            Random rand = new Random();
            int[] array = new int[n];

            Console.Write("Исходный массив: ");

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rand.Next(10);
                Console.Write(array[i] + " ");
            }

            int x = array[0];
            int max = maximum(array);
            int min = minimum(array);

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Максимум=" + max);
            Console.WriteLine("Минимум=" + min);
            Console.WriteLine();
            Console.Write("Сортировка по возрастанию: ");

            for (int i = 0; i < array.Length; i++)
            {
                for (int j = i+1; j < array.Length; j++)
                {
                    if(array[j]<array[i])
                    {
                        x = array[i];
                        array[i] = array[j];
                        array[j] = x;
                    }
                }
            }
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }





            Console.ReadKey();





        }

        static int maximum(int[] arr)
        {
            int max  = arr[0];
            for(int i =0; i<arr.Length; i++)
            {
                if (arr[i] > max)
                {
                    max = arr[i];
                }                            
            }
            return max ;
           
        }

        static int minimum(int[] arr)
        {
            int min = arr[0];
            
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] < min)
                {
                    min = arr[i];
                }
            }
            return min;
        }

        
    }
}
