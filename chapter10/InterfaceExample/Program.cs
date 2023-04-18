using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InterfaceExample
{
    interface IPrintable
    {
        void Print(object document);
    }

    public class CanonDriver : Object, IPrintable
    {
        public void Print(Object document)
        {
            // code that does the printing
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            CanonDriver driver = new CanonDriver();
            Console.WriteLine(driver is IPrintable);
            Console.ReadKey();
        }
    }
}
