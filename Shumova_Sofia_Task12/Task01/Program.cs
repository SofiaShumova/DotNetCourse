using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Task01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Чтение/запись файла");
            string path = AppDomain.CurrentDomain.BaseDirectory + "disposable_task_file.txt";

            List<string> text = new List<string>(ReadFile(path));
          
            for (int i = 0; i < text.Count; i++)
            {
                if (double.TryParse(text[i], out double n))
                {
                    text[i] = Math.Pow(n, 2).ToString();
                }
            }
            

            if (WriteFile(path, text))
            {
                Console.WriteLine("Запись в файл успешно выполнена!");
            }
            Console.ReadKey();
        }

        public static List<string> ReadFile(string pathFile)
        {
            StreamReader fs = File.OpenText(pathFile);
            List<string> res = new List<string>();

            try
            {
                while (!fs.EndOfStream)
                {
                    string line = fs.ReadLine();
                    res.Add(line);
                }

                return res;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return new List<string>();
            }
            finally
            {
                fs.Close();
            }

        }

        public static bool WriteFile(string pathFile, List<string> data)
        {
            StreamWriter fs = File.CreateText(pathFile);
            try
            {
                for (int i = 0; i < data.Count; i++)
                {
                    fs.WriteLine(data[i]);
                }

                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;

            }
            finally
            {
                fs.Close();
            }

        }



    }
}
