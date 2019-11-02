using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task01
{
    class Program
    {
        public delegate int Compare(string first, string second);
        static void Main(string[] args)
        {
            Console.WriteLine("Delegate.");
            string[] array = new string[5];
            array[1] = "abcd";
            array[0] = "avcd";
            array[2] = "a";
            array[3] = "mh";
            array[4] = "bh";


            outputArray(array);
            Sort(array);

            
            outputArray(array);

            Console.ReadKey();
        }

        static void outputArray(string[] array)
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
            if(left.Length == right.Length)
            {
                return 0;
            }
            else if(left.Length > right.Length)
            {
                return 1;
            }
            else
            {
                return 2;
            }
        }

        static void Sort(string[] items)
        {
            bool swapped;
            Compare compare = CompareLength;
            do
            {
                swapped = false;
                for (int i = 1; i < items.Length; i++)
                {
                    switch(compare(items[i - 1], items[i]))
                    {
                        case 0:
                            if(SortAlphavit(items[i - 1], items[i]))
                            {
                                Swap(items, i - 1, i);
                                swapped = true;
                            }
                            break;
                        case 1:
                            Swap(items, i - 1, i);
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
    }
}
