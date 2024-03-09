using System.Collections.Generic;

namespace N_2
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

        static void Print(int[] intArray)
        {
            foreach (int num in intArray)
            {
                Console.Write($"{num}, ");
            }
            Console.WriteLine();
        }

        static int[] RemoveMinMaxNums(int[] intArray)
        {
           List<int> intList = new List<int>(intArray);

           intList.Remove(intArray.Min());
           intList.Remove(intArray.Max());

           return intList.ToArray();
        }

        static void Main(string[] args)
        {
            int[] numsArray = GenerateRandomNums();
            Print(numsArray);
            int[] newNumsArray = RemoveMinMaxNums(numsArray);
            Print(newNumsArray);
        }
    }
}
