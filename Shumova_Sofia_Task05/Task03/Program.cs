using System;

namespace Task03
{
    class Triangle
    {
        int sideA, sideB, sideC, perimetr;
        double area;

        public int SideA
        {
            get
            {
                return sideA;
            }
            set
            {
                if(ConditionValidTriangle(value, sideB, sideC))
                {
                    sideA = value;
                }
                else
                {
                    throw new Exception("Некорректное значение!");
                }
            }
        } // метод для сеттеров условие существования треугольника, если нет кинуть исключение
        public int SideB
        {
            get
            {
                return sideB;
            }
            set
            {
                if (ConditionValidTriangle(sideA, value, sideC))
                {
                    sideB = value;
                }
                else
                {
                    throw new Exception("Некорректное значение!");
                }
            }
        }
        public int SideC
        {
            get
            {
                return sideC;
            }
            set
            {
                if (ConditionValidTriangle(sideA, sideB, value))
                {
                    sideC = value;
                }
                else
                {
                    throw new Exception("Некорректное значение!");
                }
            }
        }
        public double Area
        {
            get
            {
                double p = Perimetr / 2;
                return Math.Round(Math.Sqrt(p * (p - SideA) * (p - SideB) * (p - SideC)), 2);//округление -
            }
        }
        public int Perimetr
        {
            get
            {
                return SideA + SideB + SideC;
            }            
        }

        

        public Triangle(int x, int y, int z) // условия существования треугольника
        {
            if (ConditionValidTriangle(x, y, z))
            {
                SideA = x;
                SideB = y;
                SideC = z;
            }
            else
            {
                throw new Exception("Некорректное значение!");
            }
                                 
        }


        public override string ToString()
        {
            return ("Сторона А: " + SideA+ "\nСторона В: " + SideB+ "\nСторона С: "
                + SideC+ "\nПериметр: " + Perimetr+ "\nПлощадь: " + Area);
        }

        private bool ConditionValidTriangle(int a, int b, int c)
        {
            if ((a + b >= c) || (a + c >= b) || (b + c >= a))
            {
                return true;
            }
            return false;
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Треугольник.");
            Triangle firstTriangle = new Triangle(ParseNumberValid("сторону a"),
                ParseNumberValid("сторону b"), ParseNumberValid("сторону c"));

            Console.WriteLine();
            Console.Write(firstTriangle.ToString());
        }

        public static string GetInfo(string nameInfo)
        {
            Console.Write("Введите " + nameInfo + ": ");
            return Console.ReadLine();
        }

        public static int ParseNumberValid(string nameInfo)
        {
            int x;
            while (!(((int.TryParse(GetInfo(nameInfo), out x))) && (x > 0)))
            {
                Console.Write("Указано некорректное значение! ");
            }

            return x;
        }
    }
}
