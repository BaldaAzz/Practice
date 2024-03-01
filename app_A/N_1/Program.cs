class Program
{
    static void Main(string[] args)
    {   
        Console.Write("a= ");
        decimal a = Convert.ToDecimal(Console.ReadLine());

        Console.Write("b= ");
        decimal b = Convert.ToDecimal(Console.ReadLine());

        Console.WriteLine("{0:f2}", a+b);
        Console.ReadLine();
    }
}