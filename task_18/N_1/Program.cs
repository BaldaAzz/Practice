using System;
using System.Collections.Generic;

namespace N_1
{
    class Program
    {
        static string ProcessStringWithBackspace(string input)
        {
            Stack<char> stack = new();

            foreach (char c in input)
            {
                if (c == '#')
                {
                    if (stack.Count > 0)
                    {
                        stack.Pop();
                    }
                }
                else
                {
                    stack.Push(c);
                }
            }

            char[] resultArray = stack.ToArray();
            Array.Reverse(resultArray); 
            
            return new string(resultArray);
        }

        static void Main()
        {
            string textWithBackspace = "abc#d##c";
            string processedText = ProcessStringWithBackspace(textWithBackspace);
            
            Console.WriteLine($"Исходный текст: {textWithBackspace}");
            Console.WriteLine($"Преобразованный текст: {processedText}");
        }
    }
}