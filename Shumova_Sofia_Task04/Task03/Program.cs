using System;
using System.Globalization;

namespace Task03
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Сравнение культур.");
           
            GetCompareCulture("en-US", "ru-RU");
            Console.WriteLine();
            GetCompareCulture("de-De", "en-US");
            Console.WriteLine();
            GetCompareCulture("de-De", "ru-RU");
            Console.ReadKey();

        }

        static void GetCompareCulture(string firstCulture, string secondCulture)
        {
            DateTime dateTime = DateTime.Now;
            float number = 12.35f;
            decimal money = 400000000m;
            OutputConsole("NameCulture", firstCulture, secondCulture);
            OutputConsole("DateNow",dateTime.ToString("d",CultureInfo.CreateSpecificCulture(firstCulture)),dateTime.ToString("d",CultureInfo.CreateSpecificCulture(secondCulture)));
            OutputConsole("TimeNow", dateTime.ToString("t",CultureInfo.CreateSpecificCulture(firstCulture)), dateTime.ToString("t",CultureInfo.CreateSpecificCulture(secondCulture)));
            OutputConsole("Separator", number.ToString(CultureInfo.CreateSpecificCulture(firstCulture)), number.ToString(CultureInfo.CreateSpecificCulture(secondCulture)));
            OutputConsole("Decimal", money.ToString("N", CultureInfo.CreateSpecificCulture(firstCulture)), money.ToString("N",CultureInfo.CreateSpecificCulture(secondCulture)));
        }
        
        static void OutputConsole(string str1, string str2, string str3)
        {
            Console.WriteLine(String.Format("{0,15}  {1,25}  {2,25}", str1, str2, str3));
        }

        
    }
}
