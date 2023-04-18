using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace App06
{
    class App06
    {
        static void Main(string[] args)
        {
            Oval oval = new Oval();
            oval.WhatAmI();

            Shape shape = new Oval();
            shape.WhatAmI();

            Manager manager = new Manager("Jeff");

            Pencil pencil = new Pencil();
            pencil.Write();

            Console.ReadLine();
        }
    }


}
