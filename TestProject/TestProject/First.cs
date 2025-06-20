using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject
{
    class First
    {
        int x = 100;
        static void Main(string[] args)
        {
            First f1= new First();  //instance of a class
            First f2;               //variable of a class 
            f2 = new First();        //instance of a class
            First f3 = f1;             //Referenece of a class

            Console.WriteLine(f1.x + " " + f2.x + " " + f3.x);
            f1.x = 200;
            Console.WriteLine(f1.x + " " + f2.x + " " + f3.x);
            f2.x = 300;
            Console.WriteLine(f1.x + " " + f2.x + " " + f3.x);
            f3.x = 400;
            Console.WriteLine(f1.x + " " + f2.x + " " + f3.x);
            Console.ReadLine();
        }
    }
}
