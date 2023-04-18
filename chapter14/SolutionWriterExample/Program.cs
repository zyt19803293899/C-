using System;
using System.IO;

namespace StreamWriterExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(
                "Please type in some text. " + 
                "Keep typing until you're tired." + 
                "Enter an empty line to exit");
            using (StreamWriter writer = 
                new StreamWriter(@"C:\temp\yoursay.txt"))
            {
                String input = Console.ReadLine();
                while (input.Trim().Length != 0)
                {
                    writer.WriteLine(input);
                    input = Console.ReadLine();
                }
            }
        }
    }
}
