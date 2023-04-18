using System;
using System.Numerics;

class Numerics
{
    public void Test()
    {
        Complex c1 = new Complex(2d, 3);
        // creates a new copy of c1
        Complex c2 = c1; 
        c2 *= c2; // does not affect c1
        Console.WriteLine(c1); // prints (2, 3)
        Console.WriteLine(c2); // prints (-5, 12)
    }


}
