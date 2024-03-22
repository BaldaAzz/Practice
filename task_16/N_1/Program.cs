using System;
using System.IO;
using System.Collections.Generic;

namespace N_1
{
    class Writer
    {   
        private string fileName;
        public Writer(string fileName) => this.fileName = fileName;
        
        public void WriteNumbersInFile(int[] numbers)
        {
            using (StreamWriter sw = new(this.fileName))
            {
                foreach (int number in numbers)
                {
                    sw.WriteLine(number);
                }
            }
        }
    }

    class Reader
    {
        private string fileName;
        public int[] NumbersArray {get; private set;}

        public Reader(string fileName) => this.fileName = fileName;

        public void ReadFileWithNumbers()
        {
            List<int> numbersList = new();

            using (StreamReader sr = new(fileName))
            {
                while(!sr.EndOfStream)
                {
                    try 
                    { 
                        numbersList.Add(Convert.ToInt32(sr.ReadLine()));
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Не удалось конвертировать строку в число!");
                    }

                }
            }

            this.NumbersArray = numbersList.ToArray();
        }
    }

    class OperationWithIntArray
    {
        public static int GetMax(int[] numbers) => numbers.Max();

        public static int GetCountNegativeNumbers(int[] numbers)
        {
            int counter = 0;

            foreach (int number in numbers)
            {
                if (number < 0) ++counter;
            }

            return counter;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            string fileName = "output.txt";
            int[] numbers = {1, 2, 4, -4, -1};

            Writer fileWriter = new(fileName);
            fileWriter.WriteNumbersInFile(numbers); 

            Reader fileReader = new(fileName);
            fileReader.ReadFileWithNumbers();
            int[] numbersFromFile = fileReader.NumbersArray;

            Console.WriteLine($"Сумма: {OperationWithIntArray.GetMax(numbersFromFile)}");
            Console.WriteLine(
                $"Кол-во отрицательных чисел: {OperationWithIntArray.GetCountNegativeNumbers(numbersFromFile)}"
            );
        }
    }
}