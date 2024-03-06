namespace N_2
{
    class Program
    {
        static double f(double x)
        {
            if (x < 1) { return Math.Pow(Math.Pow(x, 2) - 1, 2); }
            if (x > 1) { return (1 / Math.Pow(1 + x, 2)); }
            return 0;
        }

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