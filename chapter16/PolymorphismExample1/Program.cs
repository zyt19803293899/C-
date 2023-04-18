using System;

namespace PolymorphismExample1
{
    class Employee {
        public virtual void Work() 
        {
            Console.WriteLine("I am an employee.");
        }
    }

    class Manager : Employee 
    {
        public override void Work() 
        {
            Console.WriteLine("I am a manager.");
        }

        public void Manage() 
        {
            Console.WriteLine("Managing ...");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Employee employee;
            employee = new Manager();
            Console.WriteLine(employee.GetType().ToString());
            employee.Work();
            Manager manager = (Manager) employee;
            manager.Manage();

            Console.ReadKey();
        }
    }
}
