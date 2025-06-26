using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionProject
{
    class Generics
    {
        static void Main()
        {
            List<int> li = new List<int>();
            li.Add(10); li.Add(20); li.Add(30); li.Add(40); li.Add(50);

            for (int i = 0; i < li.Count; i++)
                Console.Write(li[i] + " ");
            Console.WriteLine();

            li.Insert(3, 35);
            foreach (int i in li)
                Console.Write(i + " ");
            Console.WriteLine();

            li.RemoveAt(2);
            foreach (int i in li)
                Console.Write(i + " ");
            Console.WriteLine();

            //foreach (int i in li)
            //    Console.Write(i + " ");
            Console.ReadLine();


        }
    }
}
