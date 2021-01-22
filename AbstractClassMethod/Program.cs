using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassMethod
{
    public abstract class Abstract_class
    {
        public abstract void show();
        public abstract int Area(int x, int y);
    }
    public class Geek1:Abstract_class
    {
        public override void show()
        {
            Console.WriteLine("Class Geek1 and abstarct method of Abstract Class called");
        }
        public override int Area(int x, int y)
        {
            return x * y;
        }
    }
    public class Geek2 : Abstract_class
    {
        public override void show()
        {
            Console.WriteLine("Class Geek2 and abstarct method of Abstract Class called");
        }
        public override int Area(int x, int y)
        {
            throw new NotImplementedException(); // you have to implement all abstract method of abstract class
                                                // throw this exception to overcome compilation error.
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Abstract_class obj;
            obj = new Geek1();
            obj.show();
            Console.WriteLine("Multiplication of Two Number are :" + obj.Area(10, 20));
            obj = new Geek2();
            obj.show();


        }
    }
}
