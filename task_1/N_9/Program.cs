class Program
{   
    static void F(double x)
    {   
        double A = 0;
        double B = Math.PI / 2;
        int M = 20;
        double H = (B - A) / M;

        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine($"y= {Math.Sin(x) - Math.Cos(x)}");
            x += H;
        }
    }
    static void Main(string[] args)
    {
        F(12);
    }
}