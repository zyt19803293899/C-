using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace App05
{
    class Program
    {
        static void Main(string[] args)
        {
            string a = ".NET is cool";
            string b = ".NET ";
            b += "is cool";
            Console.WriteLine(a == b);

            string al = "Al";
            System.String oha = "oha";
            string greeting = al + oha;

            Console.WriteLine(greeting.EndsWith("a"));

            Console.WriteLine(greeting);

            string message = String.Concat(al, oha);
            Console.WriteLine(message);

            String s3 = "String number " + 3;
            Console.WriteLine(s3);

            // Length and Chars properties
            int stringLength = "Hello World".Length;
            Console.WriteLine(stringLength);

            string greeting2 = "Hello";
            for (int i = 0; i < greeting2.Length; i++)
            {
                Console.WriteLine(greeting2[i]);
            }

            // Substring
            Console.WriteLine("C# is cool".Substring(3, 2));

            // Replace
            Console.WriteLine("dingdong".Replace('d', 'k'));
            Console.WriteLine("Spring".Replace("Spr", "st"));

            // Concat
            Console.WriteLine(string.Concat("Hello", "World"));

            // Contains
            Console.WriteLine("Credit card".Contains("card"));

            // IndexOf
            Console.WriteLine("C# is cool".IndexOf("cool"));
            

            // LastIndexOf
            Console.WriteLine("credit card".LastIndexOf("c"));

            // Split
            string[] tokens = "big city mayors".Split(' ');
            for (int i = 0; i < tokens.Length; i++)
            {
                Console.WriteLine(tokens[i]);
            }

            StringTest stringTest = new StringTest();
            stringTest.Test();

            StringBuilderTest sbTest = new StringBuilderTest();
            sbTest.Test();

            new ArrayTest().Test();

            Console.Read();
        }
    }
}
