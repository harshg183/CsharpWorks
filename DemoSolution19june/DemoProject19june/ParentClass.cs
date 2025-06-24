using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoProject19june
{
    internal class ParentClass
    {
        public virtual void Test1()
        {
            Console.WriteLine("Method test1 from parent class");
        }
        public void Test2()
        {
            Console.WriteLine("Method test2 from parent class.");
        }
    }
    class ChildClass : ParentClass
    {
        public override void Test1()  //Method overriding
        {
            Console.WriteLine("Method test1 from child class.");
        }
        public new void Test2()     //Method hiding
        {
            Console.WriteLine("Method test2 from child class.");
        }
        static void Main()
        {
            ParentClass p = new ParentClass();
            ChildClass c = new ChildClass();
            c.Test1();
            c.Test2();
            p.Test1();
            p.Test1();

            Console.ReadLine();
        }
    }
}
