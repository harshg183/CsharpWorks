using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoProject19june
{
    class ConstructorsDemo
    {
        static int y;
        int x;
        static ConstructorsDemo()
        {
            Console.WriteLine("Static constructor is called.");
        }
        public ConstructorsDemo(int x)
        {
            this.x = x;
            Console.WriteLine("Non-Static constructor is called.");
        }
        static void Main()
        {
            Console.WriteLine("Main method is called.");

            ConstructorsDemo d1 = new ConstructorsDemo(10);
            ConstructorsDemo d2 = new ConstructorsDemo(20);

            Console.WriteLine(y);
            Console.WriteLine(d1.x + " " + d2.x);
            Console.ReadLine();
        }
    }
}
