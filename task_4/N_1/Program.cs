using System;

namespace N_1
{
    class Program
    {
        static double F1(double x)
        {
            double result = 0;
            try
            {
                result = x + (2 * x / 4 * Math.Sin(x));
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Произошло деление на нуль!!!");
            }
            catch (FormatException)
            {
                Console.WriteLine("Ожидался тип данных double!!!");
            }
            return result;
        }

        static double F2(double x)
        {
            double result = 0;

            try
            {
                result = x - 3 + (1/Math.Tan(x - 1));
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Произошло деление на нуль!!!");
            }
            catch (FormatException)
            {
                Console.WriteLine("Ожидался тип данных double!!!");
            }
            return result;
        }

        static void Main(string[] args)
        {
            Console.WriteLine(F1(-12));
            Console.WriteLine(F1(12));
            Console.WriteLine(F1(0));

            Console.WriteLine(F2(-12));
            Console.WriteLine(F2(12));
            Console.WriteLine(F2(0));
        }
    }
}
