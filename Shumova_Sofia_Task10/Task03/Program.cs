using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Task03
{
    class Program
    {


        public delegate void ThreadStart();
        static void Main(string[] args)
        {
            Console.WriteLine("Sorting.");
            string[] array = new string[5];
            array[1] = "abcd";
            array[0] = "avcd";
            array[2] = "a";
            array[3] = "mh";
            array[4] = "bh";

           
            outputArray(array);
            SortInNewThread(array);
            outputArray(array);
            Console.ReadKey();
        }
        public static void outputArray(string[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }
            Console.WriteLine();
        }

        static bool SortAlphavit(string left, string right)
        {
            for (int i = 0; i < left.Length; i++)
            {
                if (left[i] > right[i])
                {
                    return true;
                }

            }
            return false;
        }

        static int CompareLength(string left, string right)
        {
            if (left.Length == right.Length)
            {
                return 0;
            }
            else if (left.Length > right.Length)
            {
                return 1;
            }
            else
            {
                return 2;
            }
        }

        delegate int Compare(string first, string second);
        public static void Sort(string[] array)
        {
            bool swapped;
            Compare compare = CompareLength;
            do
            {
                swapped = false;
                for (int i = 1; i < array.Length; i++)
                {
                    switch (compare(array[i - 1], array[i]))
                    {
                        case 0:
                            if (SortAlphavit(array[i - 1], array[i]))
                            {
                                Swap(array, i - 1, i);
                                swapped = true;
                            }
                            break;
                        case 1:
                            Swap(array, i - 1, i);
                            swapped = true;
                            break;
                        default: break;

                    }

                }
            } while (swapped);
        }

        static void Swap(string[] items, int left, int right)
        {
            if (left != right)
            {
                string temp = items[left];
                items[left] = items[right];
                items[right] = temp;
            }
        }

        public static void SortInNewThread(string[] array)
        {
            Thread thread = new Thread(delegate () { Sort(array); });
            thread.Start();


            Thread.Sleep(300);
        }
        



    }
}
