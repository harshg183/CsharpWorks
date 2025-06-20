using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessDemo2
{
    class Four : AccessDemo1.Program
    {
        //Consuming members of a class from a child class of different project
        static void Main(string[] args)
        {
            Four f = new Four();
            f.Test3();f.Test5();f.Test4();
            Console.ReadLine();
        }
    }
}
