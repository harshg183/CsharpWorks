using System;

namespace IndexerProject
{
    class TestEmployee
    {
        static void Main()
        {
            Employee Emp = new Employee(1001, "Scott", "Manager", 20000.00, "Sales", "Mumbai");

            // Original values
            Console.WriteLine("Original Employee Info:");
            Console.WriteLine("Eno: " + Emp[0]);
            Console.WriteLine("Ename: " + Emp[1]);
            Console.WriteLine("Job: " + Emp[2]);
            Console.WriteLine("Salary: " + Emp[3]);
            Console.WriteLine("Dname: " + Emp[4]);
            Console.WriteLine("Location: " + Emp[5]);

            // Updating job and salary
            Emp[2] = "Sr.Manager";     // Job
            Emp[3] = 25000.00;         // Salary

            Console.WriteLine("\nUpdated Employee Info:");
            Console.WriteLine("Eno: " + Emp[0]);
            Console.WriteLine("Ename: " + Emp[1]);
            Console.WriteLine("Job: " + Emp[2]);
            Console.WriteLine("Salary: " + Emp[3]);
            Console.WriteLine("Dname: " + Emp[4]);
            Console.WriteLine("Location: " + Emp[5]);

            Console.ReadLine();
        }
    }
}
