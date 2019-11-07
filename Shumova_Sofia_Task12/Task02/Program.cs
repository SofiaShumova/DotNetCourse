using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.RegularExpressions;

namespace Task02
{



    class Program
    {
        static void Main(string[] args)
        {
            string path = "C:\\Users\\Софья\\Documents\\Соня\\test";
            Console.WriteLine("Отслеживание изменений файлов в " + path);
            
            Track track = new Track(path);
            track.OnBack();
            //track.OnTracking();




            Console.ReadKey();


        }
    }
}
