using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryMath;

namespace Task01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Class library. Math.");
            int x = 2, y = 5;
            Console.WriteLine($"{x}  в степени {y} ={MathFunction.Pow(x,y)}\nФакториал {y}={MathFunction.Factorial(y)}");
            
            Console.ReadKey();
        }
    }
}
