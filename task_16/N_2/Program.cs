using System.IO;

namespace N_2
{
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
            string folderName = "New_folder";
            Directory.CreateDirectory(folderName);
        }
    }
}