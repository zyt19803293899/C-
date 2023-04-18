using System;
class Shape
{
    public void WhatAmI()
    {
        Console.WriteLine("I am a shape");
    }

}

class Oval : Shape
{
    new public void WhatAmI()
    {
        Console.WriteLine("I am an oval");
    }
}