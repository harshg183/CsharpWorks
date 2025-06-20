using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessDemo1
{
    //Consuming members of a class from non-class of same project
    class Three
    {
        static void Main()
        {
            Program p = new Program();
            p.Test2();p.Test4();p.Test5();
            Console.ReadLine();
        }
    }
}
