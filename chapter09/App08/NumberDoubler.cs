using System;

class NumberDoubler
{
    public void Test()
    {
        Console.WriteLine("Please type a number"
            + " between 0 and 255 that you want to double");
        string input = Console.ReadLine();
        try 
        {
            Byte number = Byte.Parse(input);
            Console.WriteLine("Result: {0}", 2 * number);
        } 
        catch (FormatException e) {
            Console.WriteLine("Invalid input.");
            Console.WriteLine(e.StackTrace);
        }
        catch (OverflowException)
        {
            Console.WriteLine("The number you entered exceeded capacity");
        }
    }
}
