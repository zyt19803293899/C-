using System;

namespace EnumExample3
{
    enum DayOfWeek
    {
        Monday, Tuesday, Wednesday, Thursday, Friday, Saturday, Sunday
    }

    class Program
    {
        static void Main(string[] args)
        {
            DayOfWeek day = DayOfWeek.Sunday;
            switch (day)
            {
                case DayOfWeek.Monday:
                case DayOfWeek.Tuesday:
                case DayOfWeek.Wednesday:
                case DayOfWeek.Thursday:
                case DayOfWeek.Friday:
                    Console.WriteLine("Week day");
                    break;
                case DayOfWeek.Saturday:
                case DayOfWeek.Sunday:
                    Console.WriteLine("Week end");
                    break;
            }
            Console.ReadKey();
        }
    }
}
