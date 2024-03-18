using System;

namespace N_3
{
    public delegate string Del(string str);

    class Program
    {
        static string Concatenation(string str)
        {   
            string result = str + str;
            Console.WriteLine(result);
            return result;
        }

        static string RemoveLastElement(string str)
        {
            string result = str.Remove(str.Length - 1);
            Console.WriteLine(result);
            return result;
        }

        static string ToLowerCase(string str)
        {
            string result = str.ToLower();
            Console.WriteLine(result);
            return result;
        }

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