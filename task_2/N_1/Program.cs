class A
{
    public int a;
    public int b;

    public A(int a, int b)
    {
        this.a = a;
        this.b = b;
    }

    public double FunctionCalculation()
    {
        return (Math.Sin(b) + 4) / 2 * a;
    }

    public double SumConstruction()
    {
        return Math.Pow(a+b, 2);
    }
}

class Program
{
    static void Main(string[] args)
    {
        A a = new A(5, 6);

        Console.WriteLine(a.FunctionCalculation());
        Console.WriteLine(a.SumConstruction());
    }
}
