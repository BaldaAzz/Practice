using System;

namespace N_2
{
    class Program
    {
        static void DoOperation(int a, int b, Func<int, int, int> operation)
        {
            Console.WriteLine($"Результат выполнения функции: {operation(a, b)}");
        }

        static int Add(int a, int b) => a + b;
        static int Sub(int a, int b) => a - b;
        static int Div(int a, int b) => a / b;

        static void Main(string[] args)
        {
            int x = 3;
            int y = 1;

            DoOperation(x, y, Add); 
            DoOperation(x, y, Sub);

            try { DoOperation(x, y, Div); }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Произошло деление на ноль!");
            }
        }
    }
}