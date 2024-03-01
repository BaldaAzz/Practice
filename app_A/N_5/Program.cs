class Program
{
    static void Main(string[] args)
    {
        double r = 5; 
        double h = 10; 

        double V = Math.PI * Math.Pow(r, 2) * h;
        double A = 2 * Math.PI * Math.Pow(r, 2) + 2 * Math.PI * r * h;

        Console.WriteLine($"Объем цилиндра V: {V}");
        Console.WriteLine($"Площадь поверхности цилиндра A: {A}");
    }
}