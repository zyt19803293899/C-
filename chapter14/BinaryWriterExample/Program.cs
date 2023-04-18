using System;
using System.IO;

namespace BinaryReaderWriterExample
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\temp\numbers.dat";
            Random random = new Random();
            FileStream fileStream = File.OpenWrite(path);
            using (BinaryWriter writer = new BinaryWriter(fileStream))
            {
                for (int i = 0; i < 10; i++)
                {
                    writer.Write(random.Next(0, 100));
                }
            }

            fileStream = File.OpenRead(path);
            using (BinaryReader reader = new BinaryReader(fileStream))
            {
                for (int i = 0; i < 10; i++)
                {
                    int number = reader.ReadInt32();
                    Console.WriteLine(number);
                }
            }

            Console.ReadKey();
        }
    }
}
