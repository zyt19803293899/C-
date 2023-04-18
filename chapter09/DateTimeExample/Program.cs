using System;
using System.Globalization;

namespace App09
{
    class DayCalculator
    {
        public void CalculateDay()
        {
            Console.Write("\nEnter a date in MM/dd/yyyy format: ");
            DateTime selectedDate;
            string dateString = Console.ReadLine();
            string format = "MM/dd/yyyy";
            CultureInfo provider = CultureInfo.InvariantCulture;

            try 
            {
                selectedDate = DateTime.ParseExact(dateString, 
                    format, provider);
                Console.WriteLine("{0} is/was a {1}",
                    selectedDate.ToString("MMM dd, yyyy"),
                    selectedDate.DayOfWeek);

                DateTime now = DateTime.Now;
                // create DateTime with the same date this year
                DateTime thisYear = new DateTime(
                    now.Year, selectedDate.Month, 
                    selectedDate.Day);

                Console.WriteLine("This year {0} falls/fell "
                    + "on a {1}",
                    thisYear.ToString("MMM dd"),
                    thisYear.DayOfWeek);
            }
            catch (FormatException) {
                Console.WriteLine("Invalid date. Note that the "
                    + "month and date parts must be two digits. "
                    + "For example, instead of 1/1/2011, "
                    + "enter 01/01/2011");
            }
        }

        static void Main(string[] args)
        {
            DayCalculator dayCalculator =
                new DayCalculator();
            char tryAgain = 'y';
            while (tryAgain != 'n' && tryAgain != 'N')
            {
                if (tryAgain == 'y' || tryAgain == 'Y')
                {
                    dayCalculator.CalculateDay();
                }
                Console.Write("\nTry again (y/n)?");
                tryAgain = Console.ReadKey().KeyChar;
            }
        }
    }
}
