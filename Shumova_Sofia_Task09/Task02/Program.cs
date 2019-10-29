using System;
using System.Collections;
using System.Collections.Generic;

namespace Task01
{
    class DynamicArray<T> : IEnumerable
    {
        public T[] array;

        int currentIndex;
        int length;
        public int Capacity
        {
            get
            {
                return array.Length;
            }

        }
        public int Length
        {
            get
            {
                return length;
            }
            private set
            {
                if (value >=0 && value <= Capacity)
                {
                    length = value;
                }
                else
                {
                    throw new Exception("Invalid count!");
                }
            }
        }

        public DynamicArray(int count)
        {
            array = new T[count];
            Length = 0;
        }

        public DynamicArray(IEnumerable mas)
        {
            int count = 0;
            IEnumerator ie = mas.GetEnumerator();
            while (ie.MoveNext())
            {
                count++;
            }
            ie.Reset();
            array = new T[count];
            Length = 0;
            while (ie.MoveNext())
            {
              array[Length] = (T)ie.Current;
              Length++;
            }
            Reset();
        }

        public DynamicArray()
        {
            array = new T[8];

            Length = 0;
        }

        public DynamicArray(T[] mas)
        {

            array = new T[mas.Length];
            Length = mas.Length;
            for (int i = 0; i < Capacity; i++)
            {
                array[i] = mas[i];
            }
        }

        private void Resize(int newSize) 
        {

            if (newSize >= Capacity)
            {
                T[] helpArray = new T[newSize];
                for (int i = 0; i < Capacity; i++)
                {
                    helpArray[i] = array[i];
                }
                array = helpArray;
            }
            


        }
        public void Add(T element)
        {

            Resize(Capacity * 2);


            array[Length] = element;
            Length++;
        }
        public void AddRange(T[] mas)
        {
            Resize(Length + mas.Length);
            for (int i = 0; i < mas.Length; i++)
            {
                array[Length + i] = mas[i];
            }
            Length += mas.Length;

        }
        public bool Remove(T element)
        {
            for (int i = 0; i < Length; i++)
            {
                if (array[i].Equals(element))
                {
                    for (int j = i; j < Length - 1; j++)
                    {
                        array[j] = array[j + 1];
                    }
                    Length--;
                    return true;
                }
            }
            return false;
        }
        public void Insert(int index, T element)
        {
            if (index >= Length)
            {
                throw new ArgumentOutOfRangeException();
            }

            Resize(Length + 1);

            for (int i = Length; i > index; i--)
            {
                array[i] = array[i - 1];
            }
            array[index] = element;
            Length++;

        }
        public T GetElement(int index)
        {
            return array[index];
        }
        public T this[int index]
        {
            get
            {
                if (index <= Length)
                {
                    return array[index];
                }
                else
                {
                    throw new Exception("");
                }

            }
            set
            {
                if (index <= Length)
                {
                    array[index] = value;
                }
                else
                {
                    throw new Exception("");
                }

            }
        }
        public IEnumerator GetEnumerator()
        {
            return array.GetEnumerator();
        }
        public bool MoveNext()
        {
            currentIndex++;
            return currentIndex < Length; //&& currentIndex>=0);
          
        }
        public object Current
        {
            get
            {
                return array[currentIndex];
            }
        }
        public void Reset()
        {
            currentIndex = -1;
        }
    }


    class MainClass
    {
        public static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Dynamic array. IEmunerable");
                int[] arr = { 0, 4, 5, 6, 9 };

                IEnumerable  ie = arr;
                
                DynamicArray<int> dynamic = new DynamicArray<int>(ie);
               
                while (dynamic.MoveNext())
                {
                    Console.Write($"{dynamic.Current}, ");
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }



        }
    }
}
