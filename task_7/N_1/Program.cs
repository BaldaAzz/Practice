using System.Text.RegularExpressions;

namespace N_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = "Это предложение первое. А это второе предложение.";


            MatchCollection matches = Regex.Matches(text, @"(^\w+)|([\.!?] \w+ )");

            Console.WriteLine("Слова в начале предложений:");
            foreach (Match match in matches)
            {
                Console.WriteLine(match.Value);
            }

            matches = Regex.Matches(text, @" \w+[\.!?]");

            Console.WriteLine("Слова в конце предложений:");
            foreach (Match match in matches)
            {
                Console.WriteLine(match.Value);
            }
        }
    }
}
