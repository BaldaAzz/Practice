using System;

namespace N_2
{   
    /// <summary>
    /// Класс содержащий основную программу
    /// </summary>
    class Program
    {   
        /// <summary>
        /// Делегат, содержащий арифметические операции
        /// </summary>
        /// <param name="a">Первый операнд</param>
        /// <param name="b">Второй операнд</param>
        /// <returns>Результат арифметической операции</returns>
        public delegate double Del(double a, double b);

        /// <summary>
        /// Метод выполняющий программу
        /// </summary>
        /// <param name="args">Аргументы консоли</param>
        static void Main(string[] args)
        {
            Del Add = (a, b) => a + b;
            Del Sub = (a, b) => a - b;
            Del Mul = (a, b) => a * b;
            // Лямбда функция с проверкой на ноль
            Del Div = (a, b) => b != 0 ? a / b : throw new DivideByZeroException();

            int a = 3;
            int b = 4;
            Console.WriteLine($"Сложение: {Add(a, b)}");
            Console.WriteLine($"Вычитание: {Sub(a, b)}");
            Console.WriteLine($"Умножение: {Mul(a, b)}");
            Console.WriteLine($"Деление: {Div(a, b):f4}");
        }
    }
}