using System;
using System.Collections.Generic;

namespace ListExamples
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> titles = new List<string>();
            titles.Add("No Sun No Moon");
            titles.Add("The Desert Story");
            titles.Add("Belle!");

            string selectedTitle = titles[1];
            Console.WriteLine("Selected: " + selectedTitle);
            Console.WriteLine();


            foreach (string title in titles)
            {
                Console.WriteLine("title: " + title);
            }


            Console.ReadKey();
        }
    }
}
