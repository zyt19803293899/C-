using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace App07
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 123;
            Console.WriteLine(a.GetType());

            new Numerics().Test();


            Point point1 = new Point();
            point1.Print(); // prints (0, 0)
            point1.X = 10;
            point1.Y = 20;
            point1.Move(4, 5);
            point1.Print(); // prints (14, 25)

            Console.ReadKey();
        }
    }
}
