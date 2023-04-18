using System;
using System.Collections.Generic;

namespace ListOfLists
{
    class Program
    {
        static void Main(string[] args)
        {

            List<string> listOfStrings = new List<string>();
            listOfStrings.Add("Hello again");
            List<List<string>> listOfLists = new List<List<string>>();
            listOfLists.Add(listOfStrings);
            string s = listOfLists[0][0];
            Console.WriteLine(s); // prints "Hello again"
            Console.ReadKey();
        }
    }
}
