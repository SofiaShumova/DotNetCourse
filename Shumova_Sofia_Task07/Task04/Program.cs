using System;

namespace Task04
{
    class Field
    {
        protected int width = 300;
        protected int height = 200;

        public Field() { }

    }

    class Essence : Field 
    {
        int coordinateX;
        int coordinateY;

        public int CoordinateX
        {
            get
            {
                return coordinateX;
            }
            set
            {
                if(value>0 && value < width)
                {
                    coordinateX = value;
                }
                else
                {
                    throw new Exception("outside the boundaries of the playing field!");
                }
            }
        }

        public int CoordinateY
        {
            get
            {
                return coordinateY;
            }
            set
            {
                if (value > 0 && value < height)
                {
                    coordinateY = value;
                }
                else
                {
                    throw new Exception("outside the boundaries of the playing field!");
                }
            }
        }

        public Essence(int x, int y)
        {
            CoordinateX = x;
            CoordinateY = y;
        }


    }

    class Organism : Essence
    {
        //int health;
        public int Health { get; set; }

       public Organism(int x, int y, int health): base(x,y)
       {
            Health = health;
       }

        public bool LifeState()
        {
            if(Health < 0)
            {
                return false;
            }
            return true;
        }


    }

    class Player : Organism
    {
        public Player(int x, int y, int health): base(x, y, health)
        {

        }
        public void MoveX()
        {
            CoordinateX++;
        }
        public void MoveY()
        {
            CoordinateY++;
        }


    }

    class Monstr : Organism
    {
        Random random = new Random();
        int Damage { get; set; }
        public Monstr(int x, int y, int health, int damag) : base(x, y, health)
        {
            Damage = damag;
        }

        public void MoveX()
        {
            CoordinateX++;
        }
        public void MoveY()
        {
            CoordinateY++;
        }

        public void Move()
        {
            CoordinateX = random.Next(0, 300);
            CoordinateY = random.Next(0, 200);
        }

    }

    class Bonus : Essence
    {
        int Cost { get; set;  }
        public Bonus (int x, int y, int cost): base(x, y)
        {
            Cost = cost;
        }

    }




    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
