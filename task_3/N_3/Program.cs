namespace N_3
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
        /// Математическая функция
        /// Если x < 1, то переменной y будет присвоено ((x^2 - 1)^2)
        /// Если x > 1, то переменной y будет присвоено (1 / (1 + x)^2)
        /// Иначе переменной y будет присвоено 0
        /// </summary>
        /// <param name="x">Аргумент функции</param>
        static void f(double x, out double y)
        {   
            if (x < 1) { y = Math.Pow(Math.Pow(x, 2) - 1, 2); }
            else if (x > 1) { y = (1 / Math.Pow(1 + x, 2)); }
            else { y = 0; }
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

            Console.WriteLine();

            for (int i = a; i < b; i += h)
            {
                double y ;
                f(i, out y);
                Console.WriteLine($"f({i:f2})={y:f4}");
            }
        }
    }
}