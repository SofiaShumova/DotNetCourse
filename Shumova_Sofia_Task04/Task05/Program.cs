using System;
using System.Text.RegularExpressions;




namespace Task05
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Преобразование HTML-кода.");
            Console.Write("Введите HTML строку:");
            string inputString =Console.ReadLine();
            Regex regex = new Regex(@"<\w*>");

            inputString = regex.Replace(inputString, "_");

            Console.WriteLine("Результирующая строка:"+inputString);
            Console.ReadKey();
        }
    }
}
