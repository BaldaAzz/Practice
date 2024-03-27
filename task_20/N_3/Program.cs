using System;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        Task<int[]> firstTask = Task.Run(() =>
        {
            int number = GenerateUniqueThreeDigitNumber();

            int[] permutations = GetPermutations(number);

            return permutations;
        });

        Task continuationTask = firstTask.ContinueWith(task =>
        {
            int[] result = task.Result;

            Console.WriteLine("Перестановки цифр трехзначного числа:");
            foreach (int perm in result)
            {
                Console.WriteLine(perm);
            }
        });
    
        Task.WaitAll(firstTask, continuationTask);
    }

    static int GenerateUniqueThreeDigitNumber()
    {
        Random random = new Random();
        int number;
        do
        {
            number = random.Next(100, 1000);
        } while (!AreDigitsUnique(number));

        return number;
    }

    static bool AreDigitsUnique(int number)
    {
        int[] digits = new int[10];
        while (number > 0)
        {
            int digit = number % 10;
            if (digits[digit] == 1)
                return false;
            digits[digit] = 1;
            number /= 10;
        }
        return true;
    }

    static int[] GetPermutations(int number)
    {
        int[] permutations = new int[6];
        int index = 0;
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                if (i != j)
                {
                    int perm = SwapDigits(number, i, j);
                    permutations[index++] = perm;
                }
            }
        }
        return permutations;
    }

    static int SwapDigits(int number, int i, int j)
    {
        int[] digits = new int[3];
        for (int k = 0; k < 3; k++)
        {
            digits[k] = number % 10;
            number /= 10;
        }
        int temp = digits[i];
        digits[i] = digits[j];
        digits[j] = temp;
        return digits[0] * 100 + digits[1] * 10 + digits[2];
    }
}
