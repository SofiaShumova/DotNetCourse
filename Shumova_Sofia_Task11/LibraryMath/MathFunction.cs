using System;

namespace LibraryMath
{
    public class MathFunction
    {
        public static int Factorial(int number)
        {
            for (int i = number-1; i > 0; i--)
            {
                number *= i;
            }
            return number;
        }

        public static int Pow(int number, int exp)
        {
            int value = number;
            for (int i = 1; i < exp; i++)
            {
                value *= number;
            }
            return value;

        }
    }
}
