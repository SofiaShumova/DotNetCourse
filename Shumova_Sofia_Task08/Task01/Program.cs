using System;

namespace Task01
{
    class DynamicArray<T> 
    {
        public T[] array;
        int capacity;
        int length;
        public int Capacity
        {
            get
            {
                return capacity;
            }
            private set
            {
                if (value > 0)
                {
                    capacity = value;
                    array = new T[capacity];
                }
                else
                {
                    throw new Exception("Invalid size!");
                }
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
                if (value > 0 && value <= Capacity)
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
            Capacity = Length = count;
            //Count = count;
        }

        public DynamicArray()
        {
            Capacity = 8;
            Length = 0;
        }

        public DynamicArray(T[] mas)
        {
            Capacity = mas.Length;
            Length = mas.Length;
            for(int i =0; i< Capacity; i++)
            {
                array[i] = mas[i];
            }
        }

        private void Resize(int newSize)
        {
            T[] helpArray = new T[newSize];
            for(int i = 0; i< Capacity; i++)
            {
                helpArray[i] = array[i];
            }
            Capacity = newSize;
            array = helpArray;
            
        }

        public void Add(T element)
        {
            if (Capacity == Length)
            {
                Resize(Capacity * 2);
                
            }
            array[Length] = element;
            Length++;
        }

        public void AddRange(T[] mas)
        {
            if(Capacity < mas.Length + Length)
            {
                Resize(mas.Length + Length);
            }
            for (int i = 0; i < mas.Length; i++)
            {
                array[Length+i] = mas[i];
            }
            Length += mas.Length;

        }

        public bool Remove(T element)
        {
            for(int i =0; i<Length; i++)
            {
                if (array[i].Equals(element))
                {
                    for(int j = i; j<Length-1; j++)
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

            if(Capacity == Length) { Resize(Capacity+1); }

            for(int i = Length; i > index; i--)
            {
                array[i] = array[i-1];
            }
            array[index] = element;
            Length++;

        }

        public T GetElement(int index)
        {
            return array[index];
        }
    }


    class MainClass
    {
        public static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Dynamic array.");
                int[] arr = { 0, 4, 5 };
                DynamicArray<int> test = new DynamicArray<int>(arr);
                //test.Add(12);
                test.AddRange(arr);
                //test.Remove(4);
                test.Insert(20, 6);
                for (int i = 0; i < test.Length; i++)
                {

                    Console.Write($" {test.GetElement(i)}, ");
                }
                Console.WriteLine($"Length = {test.Length} Capasity = {test.Capacity}");

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }



        }
    }
}
