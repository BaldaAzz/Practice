using System;

namespace N_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<int>[] delegateArray = new Func<int>[]
            {
                () => new Random().Next(0, 9),
                () => new Random().Next(0, 9),
                () => new Random().Next(0, 9)
            };

            Func<Func<int>[], double> averageCalculator = delegates =>
            {
                int sum = 0;
                foreach (var method in delegates)
                {
                    sum += method();
                }
                return (double)sum / delegates.Length;
            };

            Console.WriteLine($"Среднее арифметическое: {averageCalculator(delegateArray)}");
        }
    }
}