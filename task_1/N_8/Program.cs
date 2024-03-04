class Program
{
    static void Main(string[] args)
    {
        double сandyCost = 15.1;

        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine($"{i}кг конфет = {i * сandyCost}rub");
        }
    }
}
