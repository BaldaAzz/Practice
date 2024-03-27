using System;
using System.Threading.Tasks;

namespace N_1
{
    class Program
    {
        static double F1(double a)
        {
            double exp1 = ((2*a) / Math.Sqrt(2*a)) - (a / Math.Sqrt(2*a) + 2) + (a - Math.Sqrt(2*a));
            double exp2 = (Math.Sqrt(a) - Math.Sqrt(2)) / a + 2;
            Thread.Sleep(3000);
            return exp1 * exp2;
        }

        static double F2(double a)
        { 
            Thread.Sleep(1000);
            return 1 / (Math.Sqrt(a) + Math.Sqrt(2));
        }

        static void Main(string[] args)
        {
            Task[] tasks = new Task[2] {
                new Task(() => Console.WriteLine(F1(3))),
                new Task(() => Console.WriteLine(F2(3)))
            };

            foreach (Task task in tasks)
                task.Start();

            // Завершение всех задач
            Task.WaitAll(tasks);

            // // Завершение хотя бы одной задачи
            // Task.WaitAny(tasks);
        }
    }
}