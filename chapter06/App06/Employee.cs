using System;
class Employee
{
    public Employee()
    {
        Console.WriteLine("Employee()");
    }
    public Employee(string name)
    {
        Console.WriteLine("Employee() " + name);
    }
}

class Manager : Employee
{
    public Manager(string name) : base(name)
    {
        Console.WriteLine("Manager() " + name);
    }
}