using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceProject
{
    internal class Class2:Class1
    {
        public Class2(int a): base(10)
        {
            Console.WriteLine("Class2 constructor is called");
        }
        public void Test3()
        {
            Console.WriteLine("Method 3");
        }
        static void Main()
        {
            
            Class2 c = new Class2(50);
            Console.ReadLine();
        }
    }
}
