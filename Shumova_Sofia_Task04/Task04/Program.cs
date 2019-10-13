using System;
using System.Diagnostics;
using System.Text;

namespace Task04
{
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch swatch = new Stopwatch();
           
            string str = "";
            StringBuilder sb = new StringBuilder();

            int N = 100;

            swatch.Start();

            for (int i = 0; i < N; i++)
            {
                str += "*";
            }

            swatch.Stop();
            Console.WriteLine("Время выполнения кода с помощью String: "+swatch.Elapsed);
            swatch.Reset();
            swatch.Start();

            for (int i = 0; i < N; i++)
            {
                sb.Append("*");
            }

            swatch.Stop();
            Console.WriteLine("Время выполнения кода с помощью StringBuilder: "+ swatch.Elapsed);

            Console.ReadKey();

        }
    }
}
