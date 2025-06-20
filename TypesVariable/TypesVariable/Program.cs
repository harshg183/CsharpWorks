using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypesVariable
{
    class Program
    {
        int x = 100;            //Non-static
        static int y = 200;     //Static
        const float pi = 3.14f;
        readonly bool flag;
        public Program(int x, bool flag)
        {
            this.x = x;
            this.flag = true;
        }
        static void Main(string[] args)
        {
            Console.WriteLine();
            Console.WriteLine();
            Program p1 = new Program(50, true);
            Program p2 = new Program(150, false);
            Console.WriteLine(p1.x + " " + p2.x);
            Console.WriteLine(p1.flag + " " + p2.flag);
            p1.x = 500;
            //p1.flag = false;
            Console.ReadLine();
        }
    }
}
