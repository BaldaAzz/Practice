using System;
using Figures;


namespace N_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Triangle triangle = new(3, 2, 3);
            Console.WriteLine($"Периметр: {triangle.CalculatePerimeter()}");
            Console.WriteLine($"Площадь: {triangle.CalculateSquare()}");
            Console.WriteLine($"Тип: {triangle.GetTypeTriangle()}");

            Console.WriteLine();

            Rectangle rectangle = new(4, 5);
            Console.WriteLine($"Периметр: {rectangle.CalculatePerimeter()}");
            Console.WriteLine($"Площадь: {rectangle.CalculateSquare()}");


        }
    }
}