using System;
using System.IO;

namespace StreamReaderExample
{
    class Program
    {
        static void Main(string[] args)
        {
            String path = "C:\\temp\\today.txt";
            try
            {
                using (StreamReader reader = File.OpenText(path))
                {
                    string line;
                    // Read and display lines from the file 
                    while ((line = reader.ReadLine()) != null)
                    {
                        Console.WriteLine(line);
                    }
                }
            }
            catch (IOException e)
            {
                Console.Write(e.Message);
            }

            Console.ReadKey();
        }
    }
}
