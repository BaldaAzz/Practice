class Program
{
    static void Main(string[] args)
    {   
        Console.Write("1$ = ");
        decimal rubCourse = Convert.ToDecimal(Console.ReadLine());

        for (int i = 5; i <= 500; i += 5)
        {
            Console.WriteLine($"{i}$ = {i * rubCourse} rub");
        } 
    }
}