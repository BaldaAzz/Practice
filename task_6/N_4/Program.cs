namespace N_4
{
    class Program
    {
        static int GetSingleDigitSum(int num)
        {
            while (num > 9)
            {
                int tempNum = num;
                int sum = 0;
                while (tempNum > 0)
                {
                    sum += tempNum % 10;
                    tempNum /= 10;
                }
                num = sum;
            }
            return num;
        }

        static void Main(string[] args)
        {
            string alphabet = "абвгдеёжзийклмнопрстуфхцчшщъыьэюя";
            string FIO = "Александр Сергеевич Пушкин";

            int nameNumber = 0;

            FIO = FIO.ToLower();

            foreach (char ch in FIO)
            {
                nameNumber += alphabet.IndexOf(ch) + 1;
            }

            Console.WriteLine(GetSingleDigitSum(nameNumber));
        }
    }
}
