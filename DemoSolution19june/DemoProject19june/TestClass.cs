using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoProject19june
{
    public enum Days : byte
    {
        Monday=1, Tuesday, Wednesday, Thursday, Friday
    }
    class TestClass
    {
        static void Main()
        {
            foreach (byte i in Enum.GetValues(typeof(Days)))
                Console.WriteLine(i + ": " + (Days)i);
            foreach (string s in Enum.GetNames(typeof(Days)))
                Console.WriteLine(s);
            Console.ReadLine();

        }
    }
}
