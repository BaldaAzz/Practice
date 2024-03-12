namespace N_2
{
    class Program
{
    static void Main()
    {
        Console.WriteLine("Введите строку, состоящую только из цифр и букв:");
        string input = Console.ReadLine();

        int digitSum = 0;

        foreach (char c in input)
        {
            if (char.IsDigit(c))
            {
                int digitValue = (int)Char.GetNumericValue(c);
                digitSum += digitValue;
            }
        }

        bool isSumEqualLength = digitSum == input.Length;

        if (isSumEqualLength)
        {
            Console.WriteLine("Сумма числовых значений цифр равна длине текста");
        }
        else
        {
            Console.WriteLine("Сумма числовых значений цифр не равна длине текста");
        }
    }
}
}
