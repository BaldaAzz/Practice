class Program
{
    public static double Func(double x)
    {
        if (x <= Math.PI) { return x + 2 * x * Math.Sin(3 * x);}
        else { return Math.Cos(x) + 2;}
    }

    static void Main(string[] args)
    {
        Console.Write("x: ");
        double x = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine($"y= {Func(x)}");
    }
}