namespace N_2
{
    /// <summary>
    /// Класс содержащий основную программу
    /// </summary>
    class Program
    {
        /// <summary>
        /// Математическая функция
        /// </summary>
        /// <param name="x">Аргумент функции</param>
        /// <returns>
        /// Если x < 1, то возвратит ((x^2 - 1)^2)
        /// Если x > 1, то возвратит (1 / (1 + x)^2)
        /// Иначе возвращает 0
        /// </returns>
        static double f(double x)
        {
            if (x < 1) { return Math.Pow(Math.Pow(x, 2) - 1, 2); }
            if (x > 1) { return (1 / Math.Pow(1 + x, 2)); }
            return 0;
        }

        /// <summary>
        /// Метод выполняющий программу
        /// </summary>
        /// <param name="args">Аргументы консоли</param>
        static void Main(string[] args)
        {
            int a = -4;
            int b = 7;
            int h = 3;

            for (int i = a; i < b; i += h)
            {
                Console.WriteLine($"f({i:f2})={f(i):f4}");
            }
        }
    }
}