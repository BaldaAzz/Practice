namespace N_5
{
    class Program
    {
        static long Factorial(int n)
        {
            if (n == 0)
            {
                return 1;
            }
            else
            {
                return n * Factorial(n - 1);
            }
        }

        static void Main(string[] args)
        {
            int n = 3;
            Console.WriteLine($"f({n})={(double)Factorial(n+2) / Factorial(n+4)}");
        }
    }
}
