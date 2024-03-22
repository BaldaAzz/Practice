using System.IO;

namespace N_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string folderName = "New_folder";
            Directory.CreateDirectory(folderName);
        }
    }
}