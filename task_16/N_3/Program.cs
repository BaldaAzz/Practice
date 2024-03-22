using System;
using System.IO;
using System.Collections.Generic;

namespace N_3
{
    class Program
    {
        static void Main(string[] args)
        {   
            List<string> stringsList = new();

            using (StreamReader streamReader = new("file.txt"))
            {
                while(!streamReader.EndOfStream)
                {
                    stringsList.Add(streamReader.ReadLine());
                }
            }

            #region a
            Console.WriteLine("Вывод всего файла");
            foreach(string stringLine in stringsList)
            {
                Console.WriteLine(stringLine);
            }
            #endregion

            Console.WriteLine();

            #region b
            Console.WriteLine($"Кол-во строк: {stringsList.Count}");
            #endregion

            Console.WriteLine();

            #region c
            Console.WriteLine("Кол-во символов в каждой строке");
            foreach(string stringLine in stringsList)
            {
                Console.WriteLine(stringLine.Length);
            }
            #endregion

            Console.WriteLine();

            #region d
            // Записть в новый файл без последней строчки
            using (StreamWriter streamWriter = new("newFile.txt"))
            {
                for (int i = 0; i < stringsList.Count -1; i++)
                {
                    streamWriter.WriteLine(stringsList[i]);
                }
            }
            #endregion

            Console.WriteLine();

            #region e
            Console.WriteLine("Вывод строк от 1 до 2");
            int s1 = 0;
            int s2 = 2;

            for (int i = s1; i < s2; i++)
            {
                Console.WriteLine(stringsList[i]);
            }
            #endregion

            Console.WriteLine();

            #region f
            Console.WriteLine("Самая длинная строка");

            int maxStringLength = stringsList[0].Length;
            int indexMaxStringLength = 0;

            for (int i = 1; i < stringsList.Count; i++)
            {
                if(maxStringLength < stringsList[i].Length)
                {
                    maxStringLength = stringsList[i].Length;
                    indexMaxStringLength = i;
                }
            }

            Console.WriteLine(stringsList[indexMaxStringLength]);
            Console.WriteLine($"Её длина: {maxStringLength}");
            #endregion

            Console.WriteLine();

            #region g
            Console.WriteLine("Вывод строк начинающихся с буквы С");

            char givenLetter = 'С';

            foreach (string stringLine in stringsList)
            {
                if(givenLetter == stringLine[0])
                {
                    Console.WriteLine(stringLine);
                }
            }
            #endregion

            Console.WriteLine();

            #region h
            // Запись строк в обратном порядке в другом файле

            using (StreamWriter streamWriter = new("newFile2.txt"))
            {
                for (int i = stringsList.Count - 1; i >= 0; i--)
                {
                    streamWriter.WriteLine(stringsList[i]);
                }
            }
            #endregion
        }
    }
}