using System;
public class Tool
{
    public string Identify() {
        return "Generic tool";
    }
}

public class Pencil : Tool {
    new public string Identify()
    {
        return "Pencil";
    }

    public void Write() {
        Console.WriteLine(base.Identify());
        Console.WriteLine(Identify());
    }

}
