using System;

namespace App10
{
    class Student : IComparable
    {
        private string firstName;
        private string lastName;

        public Student(string firstName, 
            string lastName)
        {
            this.lastName = lastName;
            this.firstName = firstName;
        }

        public string FirstName
        {
            get
            {
                return firstName;
            }
            set
            {
                firstName = value;
            }
        }

        public string LastName
        {
            get
            {
                return lastName;
            }
            set
            {
                lastName = value;
            }
        }

        public int CompareTo(Object obj)
        {
            Student anotherStudent = (Student) obj;
            if (this.lastName == anotherStudent.lastName)
            {
                return this.FirstName.CompareTo(
                    anotherStudent.FirstName);
            }
            else
            {
                return this.LastName.CompareTo(
                    anotherStudent.LastName);
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Student[] students = { 
                new Student("John", "Suzuki"),
                new Student("Liam", "Doe"),
                new Student("John", "Smith"),
                new Student("Joe", "Doe"),
                new Student("John", "Tirano"),
                new Student("Louis", "Smith")};

            Console.WriteLine("\nUnsorted:");
            Console.WriteLine("====================");
            foreach (Student student in students)
            {
                Console.WriteLine(student.LastName + 
                    ", " + student.FirstName);
            }

            Array.Sort(students);

            Console.WriteLine("\nSorted:");
            Console.WriteLine("====================");
            foreach (Student student in students)
            {
                Console.WriteLine(student.LastName +
                    ", " + student.FirstName);
            }

            Console.ReadKey();
        }
    }
}