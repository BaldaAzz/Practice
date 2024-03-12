namespace N_1
{
    class Program
    {
        static void Main()
        {
            string input = Console.ReadLine(); 

            if (IsPalindrome(input))
            {
                Console.WriteLine("Строка палиндромом");
            }
            else
            {
                Console.WriteLine("Строка не палиндромом");
            }
        }

        static bool IsPalindrome(string str)
        {   
            str = str.ToLower();
            string newStr = str.Replace(" ", string.Empty);
            char[] charArray = newStr.ToCharArray();
            Array.Reverse(charArray);
            string reverseStr = new string(charArray);

            return newStr == reverseStr;
        }
    }
}