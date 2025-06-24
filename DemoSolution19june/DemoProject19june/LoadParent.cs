using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoProject19june
{
    class LoadParent
    {
        public void Show()
        {
            Console.WriteLine("Parent's Show Method is called");
        }
        //public void Test()
        //{
        //    Console.WriteLine("Parent's Test Method is Called");
        //}
        public virtual void Test()   //Overridable
        {
            Console.WriteLine("Parent's Test Method is Called");
        }
           
         
    }
    class LoadChild : LoadParent
    {
        //overloading parent's show method in child class
        public void Show(int i)
        {
            Console.WriteLine("Child's Show Method Is Called.");
        }
        //overrinding parent's test method in child class
        public override void Test()
        {
            Console.WriteLine("child's test method is called");
        }
        static void Main()
        {
            LoadChild c = new LoadChild();
            c.Show();
            c.Show(10);
            c.Test();

            Console.ReadLine();
        }
    }
}
