using System;
using System.Threading;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите значение A:");
        int a = int.Parse(Console.ReadLine());
        Console.WriteLine("Введите значение N:");
        int n = int.Parse(Console.ReadLine());

        Console.WriteLine("Метод 1: Вычисление суммы A + A1 + A2 + A3 + ... + AN");

        // Поток для первого метода
        Thread sumThread = new Thread(() =>
        {
            double sum = 0; 
            for (int i = 1; i <= n; i++)
            {
                sum += Math.Pow(a, i);
                Console.WriteLine($"Поток 1: Промежуточная сумма на шаге {i}: {sum}");
                Thread.Sleep(1000);
            }
            Console.WriteLine($"Поток 1: Итоговая сумма: {sum}");
        });

        sumThread.Start();
        sumThread.Join();

        Console.WriteLine("Метод 2: Вычисление произведения A * A1 * A2 * A3 * ... * AN");

        // Первое вычисление
        double product = a;

        // Поток для второго метода
        Thread productThread = new Thread(() =>
        {
            for (int i = 1; i <= n; i++)
            {
                product *= Math.Pow(a, i);
                Console.WriteLine($"Поток 2: Промежуточное произведение на шаге {i}: {product}");
                Thread.Sleep(1000);
            }
            Console.WriteLine($"Поток 2: Итоговое произведение: {product}");
        });

        productThread.Start();
        productThread.Join();
    }
}
