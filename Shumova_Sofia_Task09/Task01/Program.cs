using System;
using System.Collections.Generic;

namespace Task01
{
    class MainClass 
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Remove each second item");
            Console.Write("List: ");
            List<int> list = new List<int>() { 1, 2, 3, 4, 5, 6, 7 };
            LinkedList<int> linkedlist = new LinkedList<int>(list);
            for (int i =0; i<list.Count; i++)
            {
                Console.Write($"{list[i]}, ");
            }

            Console.WriteLine("element = "+ RemoveEachSecondItem(list).ToString());
            Console.Write("LinkedList: ");
            foreach (int i in linkedlist)
            {
                Console.Write($"{i}, "); 
            }

            Console.WriteLine("element = " + RemoveEachSecondItem(linkedlist).ToString());


        }

        
        public static T RemoveEachSecondItem<T>(ICollection<T> list)
        {
            List<T> helpList = new List<T>();
            bool state = true;
            while (list.Count != 1)
            {
                helpList.Clear();
                foreach (T i in list)
                {
                    if (state)
                    {
                        helpList.Add(i);
                    }
                    state = !state;
                }
                list = new List<T>(helpList) as ICollection<T>;
            }

            return helpList[0];
            
        }
    }
    


}
