using System;
using System.IO;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Queue<char> nonDigitsQueue = new Queue<char>();
        Queue<char> digitsQueue = new Queue<char>();

        string filePath = "file.txt";

        try
        {
            using (StreamReader sr = new StreamReader(filePath))
            {
                while (!sr.EndOfStream)
                {
                    char ch = Convert.ToChar(sr.ReadLine());

                    if (char.IsDigit(ch))
                    {
                        digitsQueue.Enqueue(ch);
                    }
                    else if(ch == '\n')
                    {
                        continue;
                    }
                    else
                    {
                        nonDigitsQueue.Enqueue(ch);
                    }
                }
            }

            while (nonDigitsQueue.Count > 0)
            {
                Console.WriteLine(nonDigitsQueue.Dequeue());
            }

            while (digitsQueue.Count > 0)
            {
                Console.WriteLine(digitsQueue.Dequeue());
            }

        }
        catch (Exception e)
        {
            Console.WriteLine("Ошибка при чтении файла: " + e.Message);
        }
    }
}
