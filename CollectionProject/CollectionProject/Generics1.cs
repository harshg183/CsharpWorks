using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionProject
{
    class Generics1
    {
        public bool Compare(int a, int b)
        {
            if (a == b)
                return true;
            return false;
        }
        static void Main()
        {
            Generics1 obj = new Generics1();
            bool result = obj.Compare(10, 10);
            Console.WriteLine(result);
            Console.ReadLine(); 
        }
    }
}
