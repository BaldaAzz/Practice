namespace N_3
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Введите предложение:");
            string input = Console.ReadLine();

            // Разделение предложения на слова
            string[] words = input.Split(' ');

            // Поменять местами первое и последнее слова
            string firstWord = words[0];
            words[0] = words[words.Length - 1];
            words[words.Length - 1] = firstWord;

            // Склеить второе и третье слова
            string secondThirdConcatenated = words[1] + words[2];

            // Обратный порядок третьего слова
            char[] thirdWordChars = words[2].ToCharArray();
            Array.Reverse(thirdWordChars);
            string thirdWordReversed = new string(thirdWordChars);

            // Вырезать первые две буквы из первого слова
            string firstWordSubstring = words[0].Substring(2);

            Console.WriteLine($"Предложение с переставленными первым и последним словами: {string.Join(" ", words)}");
            Console.WriteLine($"Склеенное второе и третье слова: {secondThirdConcatenated}");
            Console.WriteLine($"Третье слово в обратном порядке: {thirdWordReversed}");
            Console.WriteLine($"Первое слово с вырезанными первыми двумя буквами: {firstWordSubstring}");
        }
    }
}