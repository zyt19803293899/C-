using System;
using System.Globalization;

namespace app09
{
    class NumberFormatTest
    {
        public static void Main()
        {
            float floatValue = 2e3f; // 2 x 10^3
            Console.WriteLine(floatValue.ToString()); //prints 2000
            int intValue = 12345;
            Console.WriteLine(intValue.ToString());

            // use format string
            Console.WriteLine(intValue.ToString("g")); //prints 12345
            Console.WriteLine(intValue.ToString("c")); //prints $12,345.00 if en-US


            CultureInfo frenchCanadian = new CultureInfo("fr-CA");
            Console.WriteLine(intValue.ToString("c", frenchCanadian));// prints 12 345,00 $
            Console.ReadKey();
        }
    }
}
