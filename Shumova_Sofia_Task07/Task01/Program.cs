using System;
using System.Collections.Generic;
//using System;
//using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.IO;
using System.Diagnostics;


namespace Task01
{
    
    abstract class Figure
    {


        protected string NameFigure { get; set;}

        protected List<int> arrayOfPoints = new List<int>();

        protected Figure(string name, int x , int y)
        {
            NameFigure = name;
            arrayOfPoints.AddRange(new int[] {x, y});
        }

        protected Figure() { }

        protected string GetFigure()
        {

            return $"Name of figure: {NameFigure}";

        }
        public abstract string Draw();
        
    }

    class Line : Figure
    {
        
        public Line( int x, int y, int x1, int y1) : base("line", x,y)
        {
            arrayOfPoints.AddRange(new int[] { x1, y1 });
        }

        protected Line(string name, int x, int y, int x1, int y1) : base(name , x,y)
        {
            arrayOfPoints.AddRange(new int[] { x1, y1 });
        }

        public override string Draw()
        {
            return GetFigure() + $"\nCoordinates: ({arrayOfPoints[0]};{arrayOfPoints[1]}) ({arrayOfPoints[2]};{arrayOfPoints[3]})";
        }

    }

    class Rectangle : Line
    {
        public Rectangle(int x, int y, int x1, int y1): base("rectangle", x, y, x1, y)
        {
            arrayOfPoints.AddRange(new int[] { x1, y1, x, y1 });
        }

        public Rectangle (int x, int y, int x1, int y1, int x2, int y2, int x3, int y3) : base("rectangle", x, y, x1, y1)
        {
            if(y==y1 && x1==x2 && y2==y3 && x3 == x)
            {
                arrayOfPoints.AddRange(new int[] { x2, y2, x3, y3 });
            }
            else
            {
                throw new Exception("Invalid rectangle coordinates!");
            }
        }

        public override string Draw()
        {
            string points="\nCoordinates: ";
            for (int i =0; i<arrayOfPoints.Count; i+=2)
            {
                points += $"({arrayOfPoints[i].ToString()};{arrayOfPoints[i+1].ToString()}) ";
            }

            return GetFigure() + points;
        }
    }

    class Circle : Figure
    {
        int externalRadius;
        protected int ExternalRadius
        {
            get
            {
                return externalRadius;  
            }
            set
            {
                if (value > 0)
                {
                    externalRadius = value;
                }
                else
                {
                    throw new Exception("Invalid radius value!");
                }
            }
        }
        public Circle(int x, int y, int radius) : base("circle", x,y)
        {
            ExternalRadius = radius;
        }
        protected Circle(string name, int x, int y, int radius) : base(name, x, y)
        {
            ExternalRadius = radius;
        }



        public override string Draw()
        {
            return GetFigure() + $"\nCoordinate of center: ({arrayOfPoints[0]},{arrayOfPoints[1]}) Radius: {ExternalRadius}";
        }

    }

    class Round : Circle
    {
        public Round(int x, int y, int radius) : base("round", x,y,radius)
        {

        }
        protected Round(string name, int x, int y, int radius) : base(name, x, y, radius)
        {

        }
        public override string Draw()
        {
            return GetFigure() + $"\nCoordinate of center: ({arrayOfPoints[0]};{arrayOfPoints[1]}) Radius: {ExternalRadius}";
        }

    }


    class Ring : Round
    {
        int internalRadius;
        int InternalRadius
        {
            get
            {
                return internalRadius;
            }
            set
            {
                if (value > 0 && value< ExternalRadius)
                {
                    internalRadius = value;
                }
                else
                {
                    throw new Exception("Invalid radius value!");
                }

            }
        }
        public Ring(int x, int y, int externalradius, int internalradius): base("ring", x, y, externalradius)
        {
            InternalRadius = internalradius;
        }
        public override string Draw()
        {
            return GetFigure() + $"\n Coordinate of center: ({arrayOfPoints[0]};{arrayOfPoints[1]})  External radius: {ExternalRadius}" +
                $" Internal radius: {InternalRadius}";
        }
    }




    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Graphics editor");

            int point = 0, point1 = 1, radius = 5;

            List<Figure> figures = new List<Figure>();
            figures.Add(new Line(point, point1, point1, point));
            figures.Add(new Rectangle(point, point1, point1, point));
            figures.Add(new Circle(point, point, radius));
            figures.Add(new Round(point, point, radius));
            figures.Add(new Ring(point, point, radius, point1));
          

            foreach(Figure i in figures)
            {
                Console.WriteLine(i.Draw());
            }



        }
    }
}
