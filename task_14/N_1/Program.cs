using System;
using System.Threading;

namespace N_1
{
    class Program
    {
        static void Method1()
        {
            for (int i = 0; i < 10; i++)
            {   
                Thread.Sleep(20);
                Console.WriteLine($"Первый поток выводит: {i}");
            }
        }

        static void Method2()
        {
            for (int i = 10; i < 20; i++)
            {
                Thread.Sleep(60);
                Console.WriteLine($"Второй поток выводит: {i}");
            }
        }

        static void Method3()
        {
            for (int i = 20; i < 30; i++)
            {
                Thread.Sleep(100);
                Console.WriteLine($"Третий поток выводит: {i}");
            }
        }
        
        static void Main(string[] args)
        {
            Thread thread1 = new(new ThreadStart(Method1));
            Thread thread2 = new(new ThreadStart(Method2));
            Thread thread3 = new(new ThreadStart(Method3));

            thread1.Start();
            thread2.Start();
            thread3.Start();
        }
    }
}