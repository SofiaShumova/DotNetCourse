using System;
using System.Text.RegularExpressions;

namespace Task07
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Определяем количество упоминаний времени в тексте.");
            Console.Write("Введите текст: ");

            string inputString = Console.ReadLine();
            Regex regex = new Regex(@"([0-1][0-9]|2[0-3]|[1-9]):[0-5][0-9]");
            MatchCollection collectionTime = regex.Matches(inputString);

            Console.WriteLine("В тексте время упоминается {0} раз.", collectionTime.Count);
            Console.ReadKey();





        }
    }
}
