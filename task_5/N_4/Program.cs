namespace N_4
{
    class Program
    {
        static void Print(int[,] intArray)
        {
            for (int i = 0; i < intArray.GetLength(0); i++)
            {
                for (int j = 0; j < intArray.GetLength(1); j++)
                {
                    Console.Write($"{intArray[i, j] } ");
                }
                Console.WriteLine();
            }
        }

        static int CalculateRowSum(int[,] array, int row)
        {
            int sum = 0;

            for (int i = 0; i < array.GetLength(1); i++)
            {
                sum += array[row, i];
            }

            return sum;
        }

        static void Main(string[] args)
        {
            int[,] array = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
            Print(array);

            int firstRowSum = CalculateRowSum(array, 0);
            int penultimateRowSum = CalculateRowSum(array, array.GetLength(0) - 2);

            if (firstRowSum > penultimateRowSum)
            {
                Console.WriteLine("Сумма элементов в первой строке больше");
            }
            else if (penultimateRowSum > firstRowSum)
            {
                Console.WriteLine("Сумма элементов в предпоследней строке больше");
            }
            else
            {
                Console.WriteLine("Суммы элементов в первой и предпоследней строках равны");
            }
        }   
    }
}