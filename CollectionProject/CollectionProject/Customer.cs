using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionProject
{
    public class Customer
    {
        public int Custid { get; set; }
        public string Name { get; set; }
        public string City { get; set; }
        public double Balance { get; set; }
    }
    class TestCustomer
    {
        static void Main()
        {
            List<Customer> Customers = new List<Customer>();

            Customer c1 = new Customer { Custid = 101, Name = "Scott", City = "Hyderabad", Balance = 28930.00 };
            Customer c2 = new Customer { Custid = 102, Name = "Harry", City = "Muradabad", Balance = 2500.00 };
            Customer c3 = new Customer { Custid = 103, Name = "Michael", City = "Amravatti", Balance = 250030.00 };
            Customer c4 = new Customer { Custid = 104, Name = "John", City = "Munnar", Balance = 32000.00 };

            Customers.Add(c1); Customers.Add(c2); Customers.Add(c3); Customers.Add(c4);

            foreach(Customer obj in Customers)
            {
                Console.WriteLine(obj.Custid + " " + obj.Name + " " + obj.City + " " + obj.Balance);
            }
            Console.ReadLine();

        }
    }
}
