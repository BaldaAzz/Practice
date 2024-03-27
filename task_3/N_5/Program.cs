using System.IO;
using System.Collections.Generic;

namespace N_5
{
    /// <summary>
    /// Класс 
    /// </summary>
    class Item
    {
        public string Word {get;}
        public int[] Pages {get;}

        public Item(string word, int[] pages)
        {
            Word = word;
            Pages = pages;
        }
    }
    
    /// <summary>
    /// Класс содержащий компоненты предметного указалеля
    /// </summary>
    class SubjectIndex
    {
        private List<Item> components = new List<Item>();

        public SubjectIndex()
        {
        }

        /// <summary>
        /// Конструктор, который считывает данные из файла
        /// </summary>
        /// <param name="fileName">Название файла</param>
        public SubjectIndex(string fileName)
        {
            Read(fileName);
        }

        /// <summary>
        /// Метод считывающий данные из файла
        /// </summary>
        /// <param name="fileName">Название файла</param>
        private void Read(string fileName)
        {
            using (StreamReader sr = new StreamReader(fileName))
            {
                while (!sr.EndOfStream)
                {
                    string[] splitStr = sr.ReadLine().Split('|');
                    string[] strPages = splitStr[1].Split(',');
                    int[] pages = new int[strPages.Length];

                    for (int i = 0; i < strPages.Length; i++)
                    {
                        pages[i] = Convert.ToInt32(strPages[i]);  
                    }

                    components.Add(new Item(splitStr[0], pages));
                }
            }
        }

        /// <summary>
        /// Добавление компонента в предметный указатель
        /// </summary>
        /// <param name="word">Слово</param>
        /// <param name="pages">Страницы, на которых оно встречается</param>
        public void Input(string word, int[] pages)
        {
            Item i = new Item(word, pages);
            components.Add(i);
        }

        /// <summary>
        /// Удаление компонета
        /// </summary>
        /// <param name="word">Слово</param>
        public void Remove(string word)
        {
            for (int i = 0; i < components.Count; i++)
            {
                if (components[i].Word == word) { components.Remove(components[i]); }
            }
        }

        /// <summary>
        /// Вывод компонентов на экран
        /// </summary>
        public void Print()
        {
            foreach (Item item in this.components)
            {
                Console.Write($"Слово: {item.Word}; Страницы: ");
                foreach (int page in item.Pages)
                {
                    Console.Write($"{page}, ");
                }
                Console.WriteLine();
            }
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
            SubjectIndex sj = new SubjectIndex("N_5/bin/Debug/net8.0/input.txt");
            sj.Print();

            Console.WriteLine();

            sj.Input("rrr", [1, 5, 6]);
            sj.Input("asds", [2, 3, 5, 6, 7]);
            sj.Print();

            Console.WriteLine();

            sj.Remove("rrr");
            sj.Print();
        }
    }
}