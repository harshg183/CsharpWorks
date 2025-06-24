using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstractImplemenation
{
    public abstract class Figure
    {
       public double Width, Height, Radius;
       public const float Pi = 3.14f;
        public abstract double GetArea();
    }
    public class Rectangle : Figure
    {
        public Rectangle(double Width, double Height)
        {
            this.Width = Width;
            this.Height = Height;
        }
        public override double GetArea()
        {
            return Width*Height;
        }
    }
    public class Circle : Figure
    {
        public Circle(double Radius)
        {
            this.Radius = Radius;
        }
        public override double GetArea()
        {
            return Pi*Radius*Radius;
        }

    }
    class TestFigures
    {
        static void Main()
        {
            Rectangle r = new Rectangle(12.76, 13.23);
            Circle c = new Circle(21.34);

            Console.WriteLine("Area of rectangle:" + r.GetArea());
            Console.WriteLine("Area of circle:" + c.GetArea());
        }
    }

}
