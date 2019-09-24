using System;

namespace Task05
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Вычислить");
            int sum = 0;
            for (int i = 0; i < 1000; i++)
            {
                if ((i % 3 == 0) || (i % 5 == 0))
                {
                    sum += i;
                }
            }
            Console.WriteLine("Сумма равна=" + sum);
            Console.ReadKey();
        }
    }
}
