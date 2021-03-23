using System;

namespace MethodHiding
{
    class A
    {
        public void Show()
        {
            Console.WriteLine("Base Class Method");
        }
    }
    class B:A
    {
        public new void Show()
        {
            base.Show(); // call hidden base class method
            Console.WriteLine("Derived Class Method");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //A obj = new A(); //base class
            //A obj = new B(); //base class
            B obj = new B();
            obj.Show(); //both base and derived method
        }
    }
}
