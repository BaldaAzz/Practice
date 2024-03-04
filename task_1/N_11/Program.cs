class Program
{
    static void Main()
    {
        int n = 235345;
        int k = 5;
        int count = 0;

        
        string nStr = n.ToString();

        for (int i = 0; i < nStr.Length; i++)
        {
            if (nStr[i] == k.ToString()[0])
            {
                count++;
            }
        }

        Console.WriteLine($"Число {k} встречается {count} раз в числе {n}");
    }
}