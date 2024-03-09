namespace N_3
{
    

    class Program
    {
        static int[,] GenerateRandomNums(int min=0, int max=9, int length=10)
        {
            int[,] matrix = new int[length, length];
            Random rnd = new Random();

            for (int i = 0; i < length; i++)
            {
                for (int j = 0; j < length; j++)
                {
                    matrix[i, j] = rnd.Next(min, max);
                }
            }
            return matrix;
        }

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

        static double GetAverageNumsMoreValue(int[,] matrix, int G)
        {
            if (matrix.Length == 0) { return 0;}

            int sum = 0;
            int count = 0;

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if(matrix[i, j] > G)
                    {
                        ++count;
                        sum += matrix[i, j];
                    }
                }
            }
            return (double)sum / count;
        }

        static int GetCountEvenNumsInRow(int[,] matrix, int row)
        {
            List<int> lst = new List<int>();
            row--; // так как индексация начинается с 0
            
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                if((matrix[row, j] % 2 == 0) && (matrix[row, j] != 0)) { lst.Add(matrix[row, j]); }
            }
            return lst.Count;
        }

        static void Main(string[] args)
        {
            int[,] matrix = GenerateRandomNums(length: 4);
            Print(matrix);

            int G = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Среднее арефметичское чисел больше {G}: {GetAverageNumsMoreValue(matrix, G):f2}");

            int k = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Количество чётных элементов {k}-ой строки: {GetCountEvenNumsInRow(matrix, k)}");
        }
    }
}