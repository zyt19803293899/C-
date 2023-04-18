using System;
using System.Collections.Generic;

namespace QueueExamples
{
    class Program
    {
        static void Main(string[] args)
        {
            // Queue test
            Queue<string> cities = new Queue<string>();
            cities.Enqueue("Ottawa");
            cities.Enqueue("Ottawa");
            cities.Enqueue("Helsinki");

            foreach (string city in cities)
            {
                Console.WriteLine("city: " + city);
            }

            while (cities.Count > 0)
            {
                Console.WriteLine("selected: " + cities.Dequeue());
            }


            Console.ReadKey();

        }
    }
}
