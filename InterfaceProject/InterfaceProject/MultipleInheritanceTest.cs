using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceProject
{
    interface Interface1
    {
        void Test();
    }
    interface Interface2
    {
        void Test();
    }
    class MultipleInheritanceTest:Interface1,Interface2
    {
        public void Test()
        {
            Console.WriteLine("Interface method implementation in child class");
        }
        static void Main()
        {
            MultipleInheritanceTest obj = new MultipleInheritanceTest();
            obj.Test();
            Console.ReadLine();
        }
    }
}
