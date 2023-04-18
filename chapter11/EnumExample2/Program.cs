using System;

namespace EnumExample2
{

    class Employee
    {
        public enum EmployeeType
        {
            FullTime,
            PartTime,
            Permanent,
            Contractor
        }
        private EmployeeType employeeType;
        public Employee(EmployeeType employeeType)
        {
            this.employeeType = employeeType;
        }
        public String getDescription()
        {
            if (employeeType == EmployeeType.Contractor)
            {
                return "Contractor, pay on hourly basis";
            }
            else if (employeeType == EmployeeType.Permanent)
            {
                return "Permanent, salary-based";
            }
            else if (employeeType == EmployeeType.PartTime)
            {
                return "Part-Time, mostly students";
            }
            else
            {
                return "Full-Time, salary-based";
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Employee.EmployeeType employeeType = Employee.EmployeeType.FullTime;
            Employee employee = new Employee(employeeType);
            Console.WriteLine(employeeType); // prints "FullTime"
            Console.WriteLine(employee.getDescription());
            Console.ReadKey();
        }
    }
}
