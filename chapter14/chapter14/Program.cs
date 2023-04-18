using System;
using System.IO;

namespace FileDirectoryExamples
{
    class Program
    {
        static void Main(string[] args)
        {
            DirectoryInfo directoryInfo = new DirectoryInfo("C:\\");
            FileInfo[] files = directoryInfo.GetFiles();
            foreach (FileInfo file in files)
            {
                Console.WriteLine(file.Name);
            }

            Console.ReadKey();
        }
    }
}
