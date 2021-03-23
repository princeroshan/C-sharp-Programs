using System;

namespace MethodOverridngKeywords
{
    class A
    {
        virtual public void Show()
        {
            Console.WriteLine("Base Class Method");
        }
    }
    class B:A
    {
        override public void Show()
        {
            Console.WriteLine("Derived Class Method");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            A obj = new A();
            obj.Show();
            A obj1 = new B();
            obj1.Show();
            B obj2 = new B();
            obj2.Show();
        }
    }
}
