using System;
using System.Text;

class StringBuilderTest
{
    public void Test()
    {
        StringBuilder builder1 = new StringBuilder();
        Console.WriteLine("Capacity:" + builder1.Capacity);
        StringBuilder builder2 = new StringBuilder("Hello Hello Hello");
        Console.WriteLine("Capacity:" + builder2.Capacity);
        string s = "Hello World";
        StringBuilder builder3 = new StringBuilder(s, 6, 5, 20);
        Console.WriteLine("SB:" + builder3.ToString());
        Console.WriteLine("SB's length:" + builder3.Length);
        Console.WriteLine("SB's max capacity:" + builder3.MaxCapacity);

        StringBuilder builder4 = new StringBuilder("Kingkong");
        builder4[0] = 'P';
        builder4[4] = 'p';
        Console.WriteLine(builder4.ToString());

        StringBuilder sb = new StringBuilder("Hi Hello");
        sb.Append("World").Insert(8, ' ').Remove(0, 3);
        Console.WriteLine(sb.ToString()); // print "Hello World"

    }

}
