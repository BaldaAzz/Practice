using System;

namespace N_1
{
    public delegate void Operations(int a, int b);
    
    class Program
    {
        static void Add(int a, int b) => Console.WriteLine(a + b);
        static void Sub(int a, int b) => Console.WriteLine(a - b);
        static void Div(int a, int b) => Console.WriteLine(a / b);

        static void Main(string[] args)
        {
            int x = 3;
            int y = 1;

            Operations op = new Operations(Add);
            op += Sub;
            op += Div;

            try { op(x, y); }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Произошло деление на ноль!");
            }
        }
    }
}