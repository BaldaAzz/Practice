using System;
using System.IO;
using System.Collections.Generic;

namespace N_1
{
    /// <summary>
    /// Класс для записи чисел в файл
    /// </summary>
    class Writer
    {   
        private string fileName;
        public Writer(string fileName) => this.fileName = fileName;
        
        /// <summary>
        /// Метод записывающий числа в файл
        /// </summary>
        /// <param name="numbers">Массив чисел</param>
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

    /// <summary>
    /// Класс для считывания чисел из файла
    /// </summary>
    class Reader
    {
        private string fileName;
        public int[] NumbersArray {get; private set;}

        public Reader(string fileName) => this.fileName = fileName;

        /// <summary>
        /// Метод считывающий числа из файла
        /// </summary>
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

    /// <summary>
    /// Класс проводящий операции над массивом числе
    /// </summary>
    class OperationWithIntArray
    {
        /// <summary>
        /// Метод который ищет максимальное число в массиве
        /// </summary>
        /// <param name="numbers">Массив чиел</param>
        /// <returns>Максимальное число массива</returns>
        public static int GetMax(int[] numbers) => numbers.Max();

        /// <summary>
        /// Метод, который считает количество отрицательных чисел в массиве чисел
        /// </summary>
        /// <param name="numbers">Массив чисел</param>
        /// <returns>Число отрицательных чисел</returns>
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

    /// <summary>
    /// Класс содержащий основную программу
    /// </summary>
    class Program
    {
        /// <summary>
        /// Метод выполняющий программу
        /// </summary>
        /// <param name="args">Аргументы консоли</param>
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