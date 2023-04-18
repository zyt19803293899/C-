using System;
using System.Globalization;

namespace TimeSpanExample
{
    class DurationCalculator
    {
        public void CalculateDuration()
        {
            TimeSpan departure;
            TimeSpan arrival;
            string format = "h\\:mm";
            bool timeValid = true;
            do
            {
                Console.Write("Departure time (hh:mm):");
                string intervalString = Console.ReadLine();
                timeValid = TimeSpan.TryParseExact(intervalString, 
                    format, CultureInfo.CurrentCulture, 
                    TimeSpanStyles.None, out departure);
                if (!timeValid)
                {
                    Console.WriteLine("Invalid time. Please "
                        + "enter your departure time in hh:mm "
                        + "format (Ex: 10:30 or 21:12)\n");
                }
            }
            while (!timeValid);

            do
            {
                Console.Write("Arrival time (hh:mm):");
                string intervalString = Console.ReadLine();
                timeValid = TimeSpan.TryParseExact(intervalString,
                    format, CultureInfo.CurrentCulture,
                    TimeSpanStyles.None, out arrival);
                if (!timeValid)
                {
                    Console.WriteLine("Invalid time. Please "
                        + "enter your arrival time in hh:mm "
                        + "format (Ex: 10:30 or 21:12)\n");
                }
            }
            while (!timeValid);

            if (arrival.CompareTo(departure) > 0)
            {
                TimeSpan duration = arrival.Subtract(departure);
                Console.WriteLine("Your flight will take {0} "
                    + "hour(s) and {1} minute(s)", 
                    duration.Hours, duration.Minutes);
            }
            else
            {
                Console.WriteLine("You have entered an arrival "
                    + "time that is earlier than the departure "
                    + "time.\nPlease try again later. ");
            }
        }

        static void Main(string[] args)
        {
            DurationCalculator calculator = new 
                DurationCalculator();
            calculator.CalculateDuration();
            Console.ReadKey();
        }
    }
}
