using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesProject
{
    public delegate void RectDelegate(double Width, double Height);
    class Rectangle
    {
        public void GetArea(double Width, double Height)
        {
            Console.WriteLine(Width * Height);
        }
        public void GetPerimeter(double Width, double Height)
        {
            Console.WriteLine(2 * (Width + Height));
        }
        static void Main()
        {
            Rectangle rect = new Rectangle();

            RectDelegate obj = rect.GetArea;
            obj += rect.GetPerimeter;


            obj.Invoke(12.34, 56.78);
            Console.WriteLine();
            obj.Invoke(1234.34, 52326.78);

            Console.ReadLine(); 
        }
    }
}
