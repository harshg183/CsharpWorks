using System;
namespace DemoProject
{
    struct MyStruct
    {
        int i;
        public void Display()
        {
            Console.WriteLine("Method in a class");
        }
        static void Main()
        {
            MyStruct m1;m1.i = 10;
            m1.Display();
            Console.ReadLine();
        }
    }
}