using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task04
{

    class MyString
    {

        //List<char> innerList;

        private List<char> InnerList
        {
            get;
            set;
        }

        public MyString(char[] charArray)
        {
            if (charArray != null)
            {
                InnerList = new List<char>(charArray);

            }
            else
            {
                InnerList = new List<char>();

            }
                
            

        }

        public static MyString operator +(MyString firstMyString, MyString secondMyString)
        {           
            return new MyString(firstMyString.InnerList.Concat(secondMyString.InnerList).ToArray()); // вернуть объект 
        }

        public static MyString operator -(MyString firstMyString, MyString secondMyString)
        {
            int countTrue = 0;
            for (int i = 0; i < firstMyString.InnerList.Count; i++)
            {
                if (firstMyString.InnerList[i] == secondMyString.InnerList[0])
                {
                    for(int j =0; j< secondMyString.InnerList.Count; j++)
                    { 
                        if(firstMyString.InnerList[i+countTrue] == secondMyString.InnerList[j])
                        {
                            countTrue++;
                        }
                       
                    }
                    if (countTrue == secondMyString.InnerList.Count)
                    {
                        firstMyString.InnerList.RemoveRange(i, secondMyString.InnerList.Count);
                        return new MyString(firstMyString.InnerList.ToArray());
                    }
                    countTrue = 0;
                }
                
            }
            return new MyString(firstMyString.InnerList.ToArray());
    
        }

        public static bool operator !=(MyString firstMyString, MyString secondMyString)
        {
            return !(firstMyString == secondMyString);
           
        }

        public static bool operator ==(MyString firstMyString, MyString secondMyString)
        {
            if( (object)firstMyString==null || (object)secondMyString==null) 
            {
                return false;
            }
          
            if (firstMyString.InnerList.Count != secondMyString.InnerList.Count)
            {
                return false;
            }
            
                for (int i = 0; i < firstMyString.InnerList.Count; i++)
                {
                    if (firstMyString.InnerList[i] != secondMyString.InnerList[i])
                    
                    {
                        return false;

                    }

                }
                return true;
            
        }

        public string ToMyString()
        {
            return string.Join(null, InnerList);
             
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("My string");

            Console.Write("Введите первую строчку: ");
            MyString firstMyString = new MyString(Console.ReadLine().ToCharArray());
            Console.WriteLine(firstMyString.ToMyString());
           

            Console.Write("Введите вторую строчку: ");
            MyString secondMyString = new MyString(Console.ReadLine().ToCharArray());

            MyString thirdMyString = firstMyString - secondMyString;

            Console.Write("Третья строка = 1-я - 2-я: ");
            Console.WriteLine(thirdMyString.ToMyString());

            Console.ReadLine();
        }



    }
}
