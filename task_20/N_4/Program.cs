using System;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        Parallel.For(-6, 6, (x) =>
        {
            double result = Math.Sin(x) - Math.Cos(x);
            Console.WriteLine($"f({x}) = {result}");
        });
    }
}
