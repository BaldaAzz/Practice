using System;

class Program
{
    static void Main()
    {
        int n = 7;
        int[,] spiralMatrix = new int[n, n];
        int value = 1;

        int left = 0, right = n - 1;
        int top = 0, bottom = n - 1;

        while (value <= n * n)
        {
            for (int i = left; i <= right; i++)
            {
                spiralMatrix[top, i] = value++;
            }
            top++;

            for (int i = top; i <= bottom; i++)
            {
                spiralMatrix[i, right] = value++;
            }
            right--;

            for (int i = right; i >= left; i--)
            {
                spiralMatrix[bottom, i] = value++;
            }
            bottom--;

            for (int i = bottom; i >= top; i--)
            {
                spiralMatrix[i, left] = value++;
            }
            left++;
        }

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                Console.Write(spiralMatrix[i, j] + "\t");
            }
            Console.WriteLine();
        }
    }
}