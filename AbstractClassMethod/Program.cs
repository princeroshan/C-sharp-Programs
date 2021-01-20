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
    }
    public class Geek1:Abstract_class
    {
        public override void show()
        {
            Console.WriteLine("Class Geek1 and abstarct method of Abstract Class called");
        }
    }
    public class Geek2 : Abstract_class
    {
        public override void show()
        {
            Console.WriteLine("Class Geek2 and abstarct method of Abstract Class called");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Abstract_class obj;
            obj = new Geek1();
            obj.show();
            obj = new Geek2();
            obj.show();


        }
    }
}
