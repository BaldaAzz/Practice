class Program
{
    static void Main()
    {
        int number = 93527;

        int smallestDigit = 9;
        int largestDigit = 0;

        int currentDigit;
        int num = number;

        while (num > 0)
        {
            currentDigit = num % 10;

            smallestDigit = Math.Min(smallestDigit, currentDigit);
            largestDigit = Math.Max(largestDigit, currentDigit);

            num = num / 10;
        }

        Console.WriteLine($"Наименьшая цифра: {smallestDigit}");
        Console.WriteLine($"Наибольшая цифра: {largestDigit}");
    }
}