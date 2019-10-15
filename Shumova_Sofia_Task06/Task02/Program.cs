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
                radiusRound = AssignValueRadius(value);
            }
        }

        public static double GetArea(double radius)
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
        public static double GetCircuit(double radius)
        {
            return 2 * Math.PI * radius;
        }

        public Round(double absсissa, double ordinate, double rad)
        {
            CenterX = absсissa;
            CenterY = ordinate;
            radiusRound = AssignValueRadius(rad);

        }

        public Round()
        {
            CenterX = 0;
            CenterY = 0;
            RadiusRound = 0;
        }

        protected double AssignValueRadius(double inputValue)
        {
            if (inputValue > 0)
            {
                return inputValue;
            }

            throw new Exception("Некорректное значение радиуса!");

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
        private Round innerRound;
        public double ExternalRadius
        {
            get
            {
                return RadiusRound;
            }
            set
            {
                RadiusRound = AssignValueRadius(value);
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
                internalRadius = AssignValueInternalRadius(value);
            }
        }

        private double AssignValueInternalRadius(double inputValue)
        {
            if (inputValue < RadiusRound && inputValue > 0)
            {
                return inputValue;
            }

            throw new Exception("Некорректное значение!");
        }

        public Ring(double absсissa, double ordinate, double rad,
            double internalRad) : base(absсissa, ordinate, rad)
        {
            externalRadius = RadiusRound;
            internalRadius = AssignValueInternalRadius(internalRad);
        }

        public Ring(Round round, double internalRad) :
            base(round.CenterX, round.CenterY, round.RadiusRound)
        {
            externalRadius = RadiusRound;
            internalRadius = AssignValueInternalRadius(internalRad);
        }

        public double GetAreaRing()
        {
            return  GetArea() - GetArea(InternalRadius);

        }

        public double GetSumCircuitRing()
        {
            return GetCircuit(ExternalRadius) + GetCircuit(InternalRadius);
        }

        public string GetRingsInfo()
        {
            return $"\nВнешний радиус: {RadiusRound} \nВнутренний радиус: {InternalRadius} " +
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
            try
            {
                Console.WriteLine("Введите данные круга.");
                Round round = new Round(ParseNumber("абсциссу"), ParseNumber("ординату"), ParseNumber("радиус"));

                Console.WriteLine();

                Console.WriteLine("Данные о круге:");
                Console.WriteLine(round);

                Console.WriteLine();

                Console.WriteLine("Введите данные кольца.");
                Ring ring = new Ring(round,ParseNumber("внутренний радиус"));

                Console.WriteLine();

                Console.WriteLine("Информация о кольце");
                Console.WriteLine(ring.GetRingsInfo());

                Console.WriteLine();

                Console.WriteLine("Полная информация");
                Console.WriteLine(ring.GetFullInfo());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

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
