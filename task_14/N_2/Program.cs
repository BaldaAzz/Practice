using System;
using System.Threading;
using System.Diagnostics;

namespace N_2
{
    class Program
    {
        static void PrintSum()
        {
            int sum = 0;

            for (int i = 0; i < 10; i++) sum += i;

            Console.WriteLine($"Сумма равна: {sum}");
        }

        static void PrintTimeResult(object str)
        {
            Stopwatch sw = new();
            
            sw.Start();
            PrintSum();
            sw.Stop();

            Console.WriteLine($"{str} поток выполнился за {sw.ElapsedMilliseconds} миллисекунд");
        }
        
        static void Main(string[] args)
        {
            Thread thread1 = new(new ParameterizedThreadStart(PrintTimeResult));
            Thread thread2 = new(new ParameterizedThreadStart(PrintTimeResult));

            thread1.Start("Первый");
            thread2.Start("Второй");     
        }
    }
}