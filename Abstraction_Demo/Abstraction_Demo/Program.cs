using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction_Demo
{
    abstract class Shape
    {
        public abstract int Area();
        public void Method1()
        {
            Console.WriteLine("Non Abstract Method1 Called");
        }
        public void Method2()
        {
            Console.WriteLine("Non Abstract Method2 Called");
        }
    }
    class Square:Shape
    {
        private int side;
        public Square(int x)
        {
            side = x;
        }
        // overriding of the abstract method of Shape 
        // class using the override keyword 
        public override int Area()
        {
            Method1();
            Console.WriteLine("Area of Square :");
            return side * side;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            // creating reference of Shape class 
            // which refer to Square class instance 
            Shape obj = new Square(4);
            obj.Method2();
            double res =obj.Area();
            Console.WriteLine(res);
            Console.ReadKey();

        }
    }
}
