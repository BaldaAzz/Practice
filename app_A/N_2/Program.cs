class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введите трехзначное число с различными цифрами:");
        int number = Convert.ToInt32(Console.ReadLine());

        if (IsThreeDigitNumber(number))
        {
            PrintNums(number);
        }
        else
        {
            Console.WriteLine("Ошибка! Не трёхзначное число или вовсе не число");
        }
    }

    static bool IsThreeDigitNumber(int num)
    {
        return num >= 100 && num <= 999;
    } 

    static void PrintNums(int num)
    {
        string numStr = num.ToString();
        string[] permutations = new string[6];

        permutations[0] = numStr[0].ToString() + numStr[1] + numStr[2];
        permutations[1] = numStr[0].ToString() + numStr[2] + numStr[1];
        permutations[2] = numStr[1].ToString() + numStr[0] + numStr[2];
        permutations[3] = numStr[1].ToString() + numStr[2] + numStr[0];
        permutations[4] = numStr[2].ToString() + numStr[0] + numStr[1];
        permutations[5] = numStr[2].ToString() + numStr[1] + numStr[0];

        foreach (string perm in permutations)
        {
            Console.WriteLine(perm);
        }
    }
}