using System;
using System.Text;
using System.Globalization;

namespace app09
{
    //listing 8.3
    class DateFormatTest
    {
        public static void Main()
        {

            //parsing
            DateTime dt;
            DateTime.TryParseExact("10-16-2012", "MM-dd-yyyy", 
                null, DateTimeStyles.None, out dt);
            Console.WriteLine(dt);
            Console.ReadKey();
        }
    }
}
