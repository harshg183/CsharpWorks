using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionProject
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Job { get; set; }
        public double Salary { get; set; }

    }
    public class Organization: IEnumerable
    {
        List<Employee> Emps = new List<Employee>();

        public void Add(Employee Emp)
        {
            Emps.Add(Emp);
        }

        public IEnumerator GetEnumerator()
        {
            
        }

    }
    public class OrganizationEnumerator : IEnumerator
    {
        public object Current
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public bool MoveNext()
        {
            throw new NotImplementedException();
        }

        public void Reset()
        {
            throw new NotImplementedException();
        }
    }

    class TestEmployee
    {
        static void Main()
        {
            Organization Employees = new Organization();


            List<Employee> Employee = new List<Employee>();
            Employees.Add(new Employee { Id = 101, Name = "Harsh", Job = "Manager", Salary = 125000.00 });
            Employees.Add(new Employee { Id = 102, Name = "Vamsi", Job = "Analyst", Salary = 65000.00 });
            Employees.Add(new Employee { Id = 103, Name = "Hashim", Job = "Developer", Salary = 66000.00 });
            Employees.Add(new Employee { Id = 104, Name = "Michael", Job = "HR", Salary = 90000.00 });
            Employees.Add(new Employee { Id = 105, Name = "Virender", Job = "Tester", Salary = 72000.00 });

            foreach(Employee Emp in Employees)
                Console.WriteLine(Emp.Id + " " + Emp.Name + " " + Emp.Job + " " + Emp.Salary);
            Console.ReadLine();

        }
    }
}
