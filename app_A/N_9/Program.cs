class Program
{
    static void Main()
    {
        double r = 5;

        double V = (4.0/3.0) * Math.PI * Math.Pow(r, 3);
        double A = 4 * Math.PI * Math.Pow(r, 2);

        Console.WriteLine($"Объем шара V: {V}");
        Console.WriteLine($"Площадь поверхности шара A: {A}");
    }
}