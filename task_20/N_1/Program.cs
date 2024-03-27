using System;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        Console.Write("Введите трёхзначное число: ");
        int number = Convert.ToInt32(Console.ReadLine());

        int hundreds = number / 100;
        int tens = (number % 100) / 10;
        int units = number % 10;

        Parallel.Invoke(
            () => Console.WriteLine(hundreds * 100 + tens * 10 + units),
            () => Console.WriteLine(hundreds * 100 + units * 10 + tens),
            () => Console.WriteLine(tens * 100 + hundreds * 10 + units),
            () => Console.WriteLine(tens * 100 + units * 10 + hundreds),
            () => Console.WriteLine(units * 100 + hundreds * 10 + tens),
            () => Console.WriteLine(units * 100 + tens * 10 + hundreds)
        );
    }
}
