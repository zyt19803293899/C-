using System;

namespace app09
{
    class NumberParsingTest
    {
        public static void Main()
        {
            Console.Write("Please type in a number:");
            String input = Console.ReadLine();
            try
            {
                int i = Int32.Parse(input);
                Console.WriteLine("The number entered: " + i);
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid user input");
            }
            Console.ReadKey();
        }
    }
}
