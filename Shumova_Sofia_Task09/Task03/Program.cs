using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Task03
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Regex");
            string sample2 = $"The rules of standard English are not legislated by a tribunal" +
                $"but emerge as an implicit consensus within a virtual community of writers, readers," +
                $"and editors. That consensus can change over time in a process as unplanned" +
                $"and uncontrollable as the vagaries of fashion.";

            string sample = $"cat Cat dog cat";
            Console.WriteLine(sample2);
            Regex regex = new Regex(@"[\W|\W\s]");
            List<int> wordsCount = new List<int>();

            List<string> arrayWord = new List<string>(regex.Split(sample2));
            Console.WriteLine();
            for(int i =0; i<arrayWord.Count; i++)
            {
                Console.Write("\n"+arrayWord[i]);
            }

            for (int i = 0; i < arrayWord.Count; i++)
            {
                int count = 1;
                for (int j = i+1; j < arrayWord.Count; j++)
                {
                    if (i != j)
                    {
                        
                        if(0 == String.Compare(arrayWord[i], arrayWord[j], true))
                        {
                            arrayWord.RemoveAt(j);
                            count++;
                        }
                        
                    }

                }
                wordsCount.Add(count);

            }

            Console.WriteLine();

            for (int i = 0; i < arrayWord.Count; i++)
            {
                Console.Write($"\n{arrayWord[i]} - repeat {wordsCount[i]} ");
            }

        }
    }
}
