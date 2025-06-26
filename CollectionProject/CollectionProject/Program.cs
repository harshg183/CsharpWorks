using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionProject
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList al= new ArrayList();
            Console.WriteLine(al.Capacity);
            al.Add(100);
            Console.WriteLine(al.Capacity);
            al.Add(200); al.Add(300); al.Add(400);
            Console.WriteLine(al.Capacity);

            foreach (object obj in al)
                Console.Write(obj + " ");
            Console.WriteLine();

            al.Insert(3, 350);
            foreach (object obj in al)
                Console.Write(obj + " ");
            Console.WriteLine();

            al.Remove(200);
            foreach (object obj in al)
                Console.Write(obj + " ");
            Console.WriteLine();

            al.RemoveAt(2);
            foreach (object obj in al)
                Console.Write(obj + " ");
            Console.WriteLine();
            Console.ReadLine();
        }
    }
}
