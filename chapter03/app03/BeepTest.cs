using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace App03
{
    class BeepTest
    {
        static void Main(string[] args)
        {
            System.Console.Beep();
            System.Threading.Thread.Sleep(500);
            System.Console.Beep();
            System.Threading.Thread.Sleep(500);
            System.Console.Beep();


        
            int i = 3;
            switch (i) {
            case 1 : 
                System.Console.WriteLine("One player is playing this game.");
                break;
            case 2 : 
                System.Console.WriteLine("Two players are playing this game.");
                break;
            case 3 : 
                System.Console.WriteLine(
                        "Three players are playing this game.");
                break;
            default: 
                System.Console.WriteLine("You did not enter a valid value.");
                break;
            }

            Console.ReadKey();
        }
    }
}
