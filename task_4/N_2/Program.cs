using System;

namespace N_2
{
    class Program
    {
        static double F(double x)
        {
            double y = 0;

            try
            {
                if (x <= -5)
                {
                    throw new Exception("Выход за диапазон!");
                }
                else if (-5 < x && x < 1)
                {
                    y = x - 3;
                }
                else
                {
                    y = (Math.Pow(x, 2) / 3 * x - 9);
                }
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Произошло деление на нуль!!!");
            }
            catch (FormatException)
            {
                Console.WriteLine("Ожидался тип данных double!!!");
            }
            return y;
        }

        static void Main(string[] args)
        {
            Console.WriteLine(F(5));
            Console.WriteLine(F(-6));
        }
    }
}