class Program
{   
    public static bool IsExistTriengle(double a, double b, double c)
    {
        return (a+b > c) && (a+c > b) && (b+c > a);
    }

    static void Main(string[] args)
    {
        Console.Write("a:");
        double a = Convert.ToDouble(Console.ReadLine());

        Console.Write("b:");
        double b = Convert.ToDouble(Console.ReadLine());

        Console.Write("c:");
        double c = Convert.ToDouble(Console.ReadLine());

        if(IsExistTriengle(a, b, c))
        {
            Console.WriteLine("Треугольник с данными сторонами существует");
        }
        else
        {
            Console.WriteLine("Треугольник с данными сторонами не существует");
        }

    }
}