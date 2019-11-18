using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.IO;
using System.Text.RegularExpressions;

namespace Task02
{



    class Program
    {
        static void Main(string[] args)
        {
            string path = "C:\\Users\\Софья\\Documents\\Соня\\test";
            Track track = new Track(path);
            Console.WriteLine("Отслеживание изменений файлов в " + path);
            Console.WriteLine("Выберите режим:");
            Console.WriteLine("0.Отслеживание \n1.Откат");
            int key = GetValue(2);
            if(key == 0)
            {
                track.OnTracking();
            }
            else if(key == 1)
            {
                track.OnBack();
            }

            
            //track.OnBack();
            track.OnTracking();
            
            //Thread.CurrentThread.Abort();



            Console.ReadKey();


        }
        public static int GetValue(int max)
        {
            int key = -1;
            while (!(int.TryParse(Console.ReadLine(), out key) && (key >= 0) && (key < max)))
            {
                Console.WriteLine("Повторите ввод:");
            }
            return key;
        }
    }
}
