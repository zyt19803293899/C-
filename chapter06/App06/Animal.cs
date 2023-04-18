class Animal
{
    public float Weight;
    public void Eat()
    {
    }
}

class Bird : Animal
{
    public int NumberOfWings = 2;
    public void Fly()
    {
    }
}

class Fish : Animal
{
    public int NumberOfFins = 2;
    public void Swim()
    {
    }
}

class Dog : Animal
{
    public int NumberOfLegs = 4;
    public void Walk()
    {
    }
}