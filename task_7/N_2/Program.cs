using System.Text.RegularExpressions;

namespace N_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = "Этот текст содержит цифру 5.";

            bool containsDigits = Regex.IsMatch(text, @"\d");

            if (containsDigits)
            {
                Console.WriteLine("Текст содержит цифры.");
            }
            else
            {
                Console.WriteLine("Текст не содержит цифр.");
            }
        }
    }
}
