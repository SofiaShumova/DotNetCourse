using System;
using System.Text.RegularExpressions;

namespace Task06
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Оценка нотаций чисел.");
            Console.Write("Введите число: ");
            string inputString = Console.ReadLine();
            Regex sampleScientificNum = new Regex("^-?[0-9]*[.,]?[0-9]+(?:[e][-+]?[0-9]+)?$");
            Regex sampleCommonNum = new Regex("^-?[0-9]*[.,]?[0-9]+$");
            if (sampleCommonNum.IsMatch(inputString) == true)
            {
                Console.WriteLine("Это число в обычной нотации");
            }
            else if (sampleScientificNum.IsMatch(inputString) == true)
            {
                Console.WriteLine("Это число в научной нотации");
            }
            else Console.WriteLine("Это не число");

            Console.ReadKey();
        }
    }
}
