using System.Text.RegularExpressions;

namespace N_3
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = "Некоторый текст";

            Regex r = new Regex(@"[йцкнгшщзхъфвпрлджчсмтьбЙЦКНГШЩЗХЪФВПРЛДЖЧМТЬБ]");
            MatchCollection mathces = r.Matches(text);
            Console.WriteLine(mathces.Count);

        }
    }
}
