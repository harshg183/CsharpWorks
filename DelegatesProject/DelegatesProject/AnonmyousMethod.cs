using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesProject
{
    public delegate string GreetingsDelegate(string name);
    class AnonmyousMethod
    {
        static void Main()
        {
            GreetingsDelegate obj = delegate(string name)
            {
                return "Hello " + name + " a very good morning!";
            };

            string str = obj.Invoke("Gupta");
            Console.WriteLine(str);

            Console.ReadLine();

        }
    }
}
