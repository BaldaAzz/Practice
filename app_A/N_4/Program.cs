class Program
{
    static void Main(string[] args)
    {
        double v0 = 10; 
        double a = 2;   
        double t = 5;   

        double S = v0 * t + 0.5 * a * t * t;
        double v = v0 + a * t;

        Console.WriteLine($"Расстояние S: {S}");
        Console.WriteLine($"Скорость v: {v}");
    }
}