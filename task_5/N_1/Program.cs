namespace N_1
{
    class Program
    {
        static int[] GenerateRandomNums(int min=-10, int max=10, int length=10)
        {
            int[] intArray = new int[length];
            Random rnd = new Random();

            for (int i = 0; i < length; i++)
            {
                intArray[i] = rnd.Next(min, max);
            }

            return intArray;
        }

        static int CountNegativeNums(int[] numbers)
        {
            return Array.FindAll(numbers, x => x < 0).Length;
        }

        static void Print(int[] intArray)
        {
            foreach (int num in intArray)
            {
                Console.Write($"{num}, ");
            }
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            int[] numsArray = GenerateRandomNums();
            Print(numsArray);
            Console.WriteLine($"Кол-во отрицательных чисел: {CountNegativeNums(numsArray)}");
        }
    }
}
