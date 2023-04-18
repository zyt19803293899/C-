using System;

namespace AbstractClassExample
{
    public abstract class DefaultPrinter
    {
        public string Describe()
        {
            return "Use this to print documents.";
        }

        public abstract void Print(object document);
    }

    public class MyPrinter : DefaultPrinter 
    {
        public override void Print(object document) {
            Console.WriteLine("Printing document");
            // some code here
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
