using System;

namespace CustomGenericType
{
    class Program
    {
        static void Main(string[] args)
        {
            Point<int> a = new Point<int>();
            a.Print();
            Point<double> b = new Point<double>(12.3, 244.4);
            b.Print();

            Console.ReadKey();
        }
    }
}
