using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class Person
{
}

class ArrayTest
{
    public void Test()
    {
        string[] names = new string[2];
        Console.WriteLine(names.GetType());
        if (names is System.Array)
        {
            Console.WriteLine("names is a System.Array");
        }

        int[] numbers = { 1, 3 };
        Console.WriteLine(numbers.GetType());

        long[] ages = new long[4];
        Console.WriteLine("first element of ages:" + ages[0]);

        Person[] persons = new Person[4];
        Console.WriteLine(persons.GetType());
        Console.WriteLine(persons[0] == null);

        Console.WriteLine("Iterating array, first method");
        string[] employees = { "John", "Paul", "George", "Ringo" };
        foreach (string employee in employees)
        {
            Console.WriteLine("Employee:" + employee);
        }

        Console.WriteLine("Iterating array, second method");
        for (int i = 0; i < employees.Length; i++)
        {
            Console.WriteLine("Employee(" + (i + 1) + "): " + employees[i]);
        }

        Console.WriteLine("Changing array size");
        int[] numbers2 = { 1, 2, 3 };
        int[] temp = new int[4];
        for (int j = 0; j < numbers2.Length; j++)
        {
            temp[j] = numbers2[j];
        }
        numbers2 = temp;
        Console.WriteLine("Length of numbers:" + numbers2.Length);

        Console.WriteLine("Array.Resize()");
        int[] numbers3 = { 2, 3, 4 };
        Array.Resize(ref numbers3, 5);
        Console.WriteLine("Length of numbers3:" + numbers3.Length);

    }
}
