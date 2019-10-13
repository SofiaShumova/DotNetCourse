using System;
 

namespace Task02
{
    class Round
    {
        double centerX, centerY, radiusRound;      
      
        public double CenterX { get; set; }
        public double CenterY { get; set; }
        public double RadiusRound
        {
            get
            {
                return radiusRound;
            }
            set
            {
                AssignValueRadius(value, out radiusRound);
            }
        } //проверку на отриц
        public double GetArea()
        {
            return Math.PI * Math.Pow(RadiusRound, 2); // убрать округление
        }
        public double GetCircuit()
        {
            return 2 * Math.PI * RadiusRound;
        }



        public Round(double absсissa, double ordinate, double rad)
        {
            CenterX = absсissa;
            CenterY = ordinate;
            AssignValueRadius(rad, out radiusRound);

        }

        public Round()
        {
            CenterX = 0;
            CenterY = 0;
            RadiusRound = 0;
        }
        private void AssignValueRadius(double inputValue, out double outputValue)
        {
            if (inputValue > 0)
            {
                outputValue = inputValue;
            }
            else
            {
                throw new Exception("Некорректное значение радиуса!");
            }
        }

        public override string  ToString() // винтерполяция строк, форматирование строк, округление
        {
            return $"Абсцисса центра: {CenterX} \nОрдината центра: {CenterY}" +
                $"\nРадиус: {RadiusRound} \nДлина окружности: {GetCircuit()} " +
                $"\nПлощадь:  {GetArea()} ";
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Круг.");
            Round round = new Round(ParseNumber("абсциссу"), ParseNumber("ординату"), ParseNumber("радиус")); // проверять значения здесь
            Console.WriteLine();
            Console.Write(round.ToString());
        }

        public static string GetInfo(string nameInfo)
        {
            Console.Write("Введите " + nameInfo + ": ");
            return Console.ReadLine();
        }

        public static double ParseNumber(string nameInfo)
        {
            double x;
            while (!(double.TryParse(GetInfo(nameInfo), out x)))
            {
                Console.Write("Указано некорректное значение! ");
                
            }

            return x;
        }

        public static double ParseNumberValid(string nameInfo)
        {
            double x;
            while (!(((double.TryParse(GetInfo(nameInfo), out x))) && (x>0)))
            {
                Console.Write("Указано некорректное значение! ");
            }

            return x;
        }
    }
}
