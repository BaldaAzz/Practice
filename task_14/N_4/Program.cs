using System;
using System.Threading;

class Program
{
    static void Main()
    {
        int[] a = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        int sum = 0;

        Thread thread1 = new(() => {
            for(int i = 0; i < a.Length/2; ++i)
            {
                if (a[i] % 2 == 0)
                    sum += a[i];
            }
        });

        Thread thread2 = new(() => {
            for(int i = a.Length/2; i < a.Length; ++i)
            {
                if (a[i] % 2 == 0)
                    sum += a[i];
            }
        });

        thread1.Start();
        thread2.Start();

        thread1.Join();
        thread2.Join();

        Console.WriteLine($"Общая сумма четных чисел: {sum}");
    }
}