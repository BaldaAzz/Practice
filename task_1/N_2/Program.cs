class Program
{
    public static string Reverse( string s )
    {
        char[] charArray = s.ToCharArray();
        Array.Reverse( charArray );
        return new string( charArray );
    }

    public static bool IsNumReadLefToRightEquelRightToLeft(int number)
    {
        string strNumber = Convert.ToString(number);
        string reverseStrNumber = Reverse(strNumber);

        for (int i = 0; i < strNumber.Length; i++)
        {
            if(strNumber[i] != reverseStrNumber[i]) { return false;}
        }

        return true;
    }

    static void Main(string[] args)
    {
        int number = 123321;

        if (IsNumReadLefToRightEquelRightToLeft(number))
        {
            Console.WriteLine("Данное четырехзначное число читается одинаково слева направо и справа налево");
        }
        else
        {
            Console.WriteLine("Данное четырехзначное число читается не одинаково слева направо и справа налево");
        }
    }

    
}