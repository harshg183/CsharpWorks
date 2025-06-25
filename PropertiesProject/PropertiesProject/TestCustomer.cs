using System;

namespace PropertiesProject
{
    public class Program
    {
        static void Main(String[] args)
        {
            //getters & setters = add security to fields by encapsulation
            //                    They're accessors found within properties

            // properties = combine aspects of both fields and methods (share name with a field)
            // get accessor = used to return the property value
            // set accessor = used to assign a new value
            // value keyword = defines the value being assigned by the set (parameter)
            Car car = new Car(10);
            car.Speed = 1000000000;
            Console.WriteLine(car.Speed);
            Console.ReadKey();
        }
    }

    public class Car
    {
        private int speed;
        public Car(int speed)
        {
            Speed = speed;
        }
        public int Speed
        {
            get
            {
                return speed;
            }
            set
            {
                if (value > 100)
                {
                    speed = 100;
                }
                else
                {
                    speed = value;
                }
            }
        }

    }
}