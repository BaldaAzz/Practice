class Program
{
    static void Main(string[] args)
    {
        Console.Write("N: ");
        double N = Convert.ToDouble(Console.ReadLine());

        double sum = 0.0;

        for (int i = 1; i <= N; i++)
        {
            sum += 1.0/i;
        }

        Console.WriteLine(sum);
    }
}