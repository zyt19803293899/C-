struct Point
{
    public int X;
    public int Y;

    public void Move(int x, int y)
    {
        X += x;
        Y += y;
    }

    public void Print()
    {
        System.Console.WriteLine("(" + X + ", " + Y + ")");
    }
}
