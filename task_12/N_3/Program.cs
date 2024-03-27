using System;

namespace N_3
{
    /// <summary>
    /// Делегат, содержажий методы для манипуляции строками
    /// </summary>
    /// <param name="str">Строка</param>
    /// <returns>Изменённая строка</returns>
    public delegate string Del(string str);

    /// <summary>
    /// Класс содержащий основную программу
    /// </summary>
    class Program
    {
        /// <summary>
        /// Сложение двух строк
        /// </summary>
        /// <param name="str">Строка</param>
        /// <returns>Присоеденение одной строки к другой</returns>
        static string Concatenation(string str)
        {   
            string result = str + str;
            Console.WriteLine(result);
            return result;
        }

        /// <summary>
        /// Удаление последнего символа из строки
        /// </summary>
        /// <param name="str">Строка</param>
        /// <returns>Строку без последнего символа</returns>
        static string RemoveLastElement(string str)
        {
            string result = str.Remove(str.Length - 1);
            Console.WriteLine(result);
            return result;
        }

        /// <summary>
        /// Изменяет все символы в нижний регистр
        /// </summary>
        /// <param name="str">Строка</param>
        /// <returns>Строку в нижнем регистре</returns>
        static string ToLowerCase(string str)
        {
            string result = str.ToLower();
            Console.WriteLine(result);
            return result;
        }

        /// <summary>
        /// Метод выполняющий программу
        /// </summary>
        /// <param name="args">Аргументы консоли</param>
        static void Main(string[] args)
        {
            string str = "aBc";

            Del del = new Del(Concatenation);
            del += RemoveLastElement;
            del += ToLowerCase;

            del(str);
        }
    }
}