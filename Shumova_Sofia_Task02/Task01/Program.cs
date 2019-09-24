using System;

namespace Task01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Программа, расчитывающая площадь прямоугольника!");
            int a, b, c; bool state = false;
            while (!state)
            {
                Console.WriteLine("Введите высоту прямоугольника:");
                while (!(Int32.TryParse(Console.ReadLine(), out a)))
                {
                    Console.WriteLine("Повторите ввод, необходимо ввести целое число:");
                }

                Console.WriteLine("Введите длину прямоугольника:");
                while (!(Int32.TryParse(Console.ReadLine(), out b)))
                {
                    Console.WriteLine("Повторите ввод, необходимо ввести целое число:");
                }

                if ((a <= 0) || (b <= 0))
                {
                    Console.WriteLine("Ошибка данных, число должно быть больше нуля, введите 1 для повторного ввода,\nдля выхода из программы нажмите любую кнопку");
                    switch (Console.ReadLine())
                    {
                        case ("1"):

                            state = false; break;

                        default:

                            state = true;
                            break;

                    }
                }
                else
                {
                    Console.WriteLine("Площадь прямоугольника=" + a * b);

                    Console.WriteLine("Введите 1 для повторного ввода, для выхода из программы нажмите любую кнопку");
                    switch (Console.ReadLine())
                    {
                        case ("1"):

                            state = false; break;

                        default:

                            state = true;
                            break;
                    }
                }
            }
        }
    }
}
