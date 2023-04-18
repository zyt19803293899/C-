using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Globalization;

namespace app08
{
    //listing 8.3
    class DateFormatTest
    {
        public static void Main()
        {
            DateTime now = DateTime.Now;
            CultureInfo culture = new CultureInfo("en-US");
            Console.WriteLine("format us " + now.ToString(culture));
            Console.WriteLine("short format " + now.ToString("d", culture));
            Console.WriteLine("long format " + now.ToString("D", culture));
            Console.WriteLine("full short format " + now.ToString("f", culture));
            Console.WriteLine("full long format " + now.ToString("F", culture));

            Console.ReadKey();
        }
    }
}
