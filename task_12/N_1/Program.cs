using System;

// Это задание может показаться слишком похожим на пример, который вы дали.
// Но в ТЗ дадены точные название делегата, методов и объекта.

namespace N_1
{
    /// <summary>
    /// Класс содержащий основную программу
    /// </summary>
    class Program
    {
        /// <summary>
        /// Делегат содержащий методы для работы с радиусом окружности
        /// </summary>
        /// <param name="R">Радиус</param>
        /// <returns>Вычесления с радиусом</returns>
        public delegate double CalcFigure(double R);

        /// <summary>
        /// Метод для вычесления длины окружности
        /// </summary>
        /// <param name="R">Радиус</param>
        /// <returns>Длина окружности</returns>
        static double GetLength(double R)
        {
            double result = 2 * Math.PI * R;
            Console.WriteLine($"Длина окружности: {result:f4}");
            return result;
        }

        /// <summary>
        /// Метод для вычесления площади круга
        /// </summary>
        /// <param name="R">Радиус</param>
        /// <returns>Полощадь круга</returns>
        static double GetArea(double R)
        {
            double result = Math.PI * Math.Pow(R, 2);
            Console.WriteLine($"Площадь круга: {result:f4}");
            return result;
        }

        /// <summary>
        /// Метод для вычесления объёма шара
        /// </summary>
        /// <param name="R">Радиус</param>
        /// <returns>Объём шара</returns>
        static double GetVolume(double R)
        {
            double result = 4/3 * Math.PI * Math.Pow(R, 3);
            Console.WriteLine($"Объём шара: {result:f4}");
            return result;
        }

        /// <summary>
        /// Метод выполняющий программу
        /// </summary>
        /// <param name="args">Аргументы консоли</param>
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