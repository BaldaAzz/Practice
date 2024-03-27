namespace N_1
{
    /// <summary>
    /// Класс содержащий основную программу
    /// </summary>
    class Program
    {
        /// <summary>
        /// Метод выполняющий математическую функцию x^n / n
        /// </summary>
        /// <param name="n">Входное число</param>
        /// <param name="x">Аргумент функции</param>
        /// <returns>Результат функции (x^n / n) типа double</returns>
        static double f(int n, double x)
        {
            return Math.Pow(x, n) / n;
        }

        /// <summary>
        /// Метод выполняющий программу
        /// </summary>
        /// <param name="args">Аргументы консоли</param>
        static void Main(string[] args)
        {
            double x = 15;

            Console.WriteLine(f(2, x) + f(4, x) + f(6, x));
        }
    }
}
