using System;

namespace Task02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Дублирование символов.");

            
            string firstString = GetString("первую");
            string secondString = GetString("вторую");

            Console.Write("Результирующая строка:");
            for (int i = 0; i < firstString.Length; i++)
            {
                if ((secondString.Contains(firstString[i]))&&(firstString[i]!=' '))
                {
                    Console.Write(firstString[i]);
                    
                }
                Console.Write(firstString[i]);
            }    
        Console.ReadKey();
        }


        static string GetString(string name)
        {
            Console.Write("Введите {0} строку:", name);
            return Console.ReadLine();
        }
}
}
