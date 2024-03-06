namespace N_1
{
    class Program
    {
        static double f(int n, double x)
        {
            return Math.Pow(x, n) / n;
        }

        static void Main(string[] args)
        {
            double x = 15;

            Console.WriteLine(f(2, x) + f(4, x) + f(6, x));
        }
    }
}
