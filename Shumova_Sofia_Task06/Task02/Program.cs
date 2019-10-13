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
        }

        public double GetArea(double radius)
        {
            return Math.PI * Math.Pow(radius, 2);
        }
        public double GetArea()
        {
            return Math.PI * Math.Pow(RadiusRound, 2);
        }

        public double GetCircuit()
        {
            return 2 * Math.PI * RadiusRound;
        }
        public double GetCircuit(double radius)
        {
            return 2 * Math.PI * radius;
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

        public override string ToString() // винтерполяция строк, форматирование строк, округление
        {
            return $"Абсцисса центра: {CenterX} \nОрдината центра: {CenterY}" +
                $"\nРадиус: {RadiusRound} \nДлина окружности: {GetCircuit()} " +
                $"\nПлощадь:  {GetArea()} ";
        }

    }



    class Ring : Round
    {
        double externalRadius, internalRadius;

        public double ExternalRadius
        {
            get
            {
                return externalRadius;
            }
            set
            {
                AssignValueExternalRadius(value, out externalRadius);
            }
        }
        public double InternalRadius
        {
            get
            {
                return internalRadius;
            }
            set
            {
                AssignValueInternalRadius(value, out internalRadius);
            }
        }

        private void AssignValueExternalRadius(double inputValue, out double outputValue)
        {
            if (inputValue > RadiusRound)
            {
                outputValue = inputValue;
            }
            else
            {
                throw new Exception("Некорректное значение!");
            }
        }
        private void AssignValueInternalRadius(double inputValue, out double outputValue)
        {
            if (inputValue < RadiusRound && inputValue > 0)
            {
                outputValue = inputValue;
            }
            else
            {
                throw new Exception("Некорректное значение!");
            }
        }

        public Ring(double absсissa, double ordinate, double rad, double externalRad,
            double internalRad) : base(absсissa, ordinate, rad)
        {
            AssignValueExternalRadius(externalRad, out externalRadius);
            AssignValueInternalRadius(internalRad, out internalRadius);
        }

        public Ring(Round round, double externalRad, double internalRad) :
            base(round.CenterX, round.CenterY, round.RadiusRound)
        {
            AssignValueExternalRadius(externalRad, out externalRadius);
            AssignValueInternalRadius(internalRad, out internalRadius);
        }

        public double GetAreaRing()
        {
            return GetArea(ExternalRadius) - GetArea(InternalRadius);

        }

        public double GetSumCircuitRing()
        {
            return GetCircuit(ExternalRadius) + GetCircuit(InternalRadius);
        }

        public string GetRingsInfo()
        {
            return $"\nВнешний радиус: {ExternalRadius} \nВнутренний радиус: {InternalRadius} " +
                $"\nСумма окружностей: {GetAreaRing()} \nПлощадь кольца: {GetSumCircuitRing()}";

        }

        public string GetFullInfo()
        {
            return ToString() + GetRingsInfo();
        }
    }



    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите данные круга.");
            Round round = new Round(ParseNumber("абсциссу"), ParseNumber("ординату"), ParseNumber("радиус"));

            Console.WriteLine();

            Console.WriteLine("Данные о круге:");
            round.ToString();

            Console.WriteLine();

            Console.WriteLine("Введите данные кольца.");
            Ring ring = new Ring(round, ParseNumber("внешний радиус"), ParseNumber("внутренний радиус"));

            Console.WriteLine();

            Console.WriteLine("Информация о кольце");
            Console.WriteLine(ring.GetRingsInfo());

            Console.WriteLine();

            Console.WriteLine("Полная информация");
            Console.WriteLine(ring.GetFullInfo());
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

        public static string GetInfo(string nameInfo)
        {
            Console.Write("Введите " + nameInfo + ": ");
            return Console.ReadLine();
        }
    }
}
