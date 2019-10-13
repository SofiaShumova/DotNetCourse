using System;

namespace Task01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Среднее кол-во символов в слове");
            Console.Write("Введите строку:");
            string inputString = Console.ReadLine();
            int countSpace = 1;
            int countChar = 0;
            for(int i =0; i<inputString.Length; i++)
            {
                if(inputString[i]==' ')
                {
                    countSpace++;
                }
                else if(Char.IsLetter(inputString,i))
                {
                    
                    countChar++;
                }
            }
            Console.WriteLine("Cреднее число букв в слове:" + (countChar / countSpace));
                

            
            Console.ReadKey();
        }
    }
}
