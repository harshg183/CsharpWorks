using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndexerProject
{
    class TeatEmployee
    {
        static void Main()
        {
            Employee Emp = new Employee(1001, "Scott", "Manager", 20000.00, "Sales", "Mumbai");
            Console.WriteLine("Eno:" + Emp[0]);
            Console.WriteLine("Ename:" + Emp[1]);
            Console.WriteLine("Job:" + Emp[2]);
            Console.WriteLine("Salary:" + Emp[3]);
            Console.WriteLine("Dname:" + Emp[4]);
            Console.WriteLine("Location:" + Emp[5]);

            Emp[3] = "Sr.Manager";
            Emp[4] = 25000.00;

            Console.WriteLine();
            Console.WriteLine("Eno:" + Emp[1]);
            Console.WriteLine("Ename:" + Emp[2]);
            Console.WriteLine("Job:" + Emp[3]);
            Console.WriteLine("Salary:" + Emp[4]);
            Console.WriteLine("Dname:" + Emp[5]);
            Console.WriteLine("Location:" + Emp[6]);


            Console.ReadLine();
        }
    }
}
