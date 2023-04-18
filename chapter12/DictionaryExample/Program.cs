using System;
using System.Collections.Generic;

namespace DictionaryExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> flowers = 
                    new Dictionary<int, string>();
            flowers.Add(1001, "Lily");
            flowers.Add(1002, "Rose");
            flowers.Add(1003, "Lotus");

            string favorite = flowers[1002];
            Console.WriteLine(favorite);

            Console.ReadKey();
        }
    }
}
