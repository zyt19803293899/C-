using System;
using System.Collections.Generic;

namespace DictionaryExamples
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> capitals = new Dictionary<string, string>();
            capitals.Add("France", "Paris");
            capitals.Add("Australia", "Canberra");
            capitals.Add("Canada", "Ottawa");

            Console.WriteLine(capitals["Canada"]); // prints "Ottawa"

            Console.ReadKey();
        }
    }
}
