using System;

// Это задание может показаться слишком похожим на пример, который вы дали.
// Но в ТЗ дадены точные название делегата, методов и объекта.

namespace N_1
{
    class Program
    {
        public delegate double CalcFigure(double R);

        static double GetLength(double R)
        {
            double result = 2 * Math.PI * R;
            Console.WriteLine($"Длина окружности: {result:f4}");
            return result;
        }

        static double GetArea(double R)
        {
            double result = Math.PI * Math.Pow(R, 2);
            Console.WriteLine($"Площадь круга: {result:f4}");
            return result;
        }

        static double GetVolume(double R)
        {
            double result = 4/3 * Math.PI * Math.Pow(R, 3);
            Console.WriteLine($"Объём шара: {result:f4}");
            return result;
        }

        static void Main(string[] args)
        {
            double R = 3;
            CalcFigure CF = new CalcFigure(GetLength);
            CF += GetArea;
            CF += GetVolume;

            CF(R);
        }
    }
}