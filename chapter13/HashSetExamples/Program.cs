using System;
using System.Collections.Generic;

namespace HashSetExamples
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> productCodes = new HashSet<string>();
            bool added = productCodes.Add("1234");
            Console.WriteLine("1234 added? " + added);
            added = productCodes.Add("1234"); // duplicate, this won't be added
            Console.WriteLine("1234 added? " + added);
            added = productCodes.Add("999");
            Console.WriteLine("999 added? " + added);

            Console.WriteLine("\nProduct Codes:");
            foreach (string productCode in productCodes)
            {
                Console.WriteLine("product code: " + productCode);
            }


            Console.ReadKey();
        }
    }
}
