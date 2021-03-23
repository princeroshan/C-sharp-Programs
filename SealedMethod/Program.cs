using System;

namespace SealedMethod
{
    class Base_Class
    {
        public virtual void Show()
        {
            Console.WriteLine("Virtual Base Method show");
        }
        public virtual void Disp()
        {
            Console.WriteLine("Virtual Base Method disp");
        }
    }
    class Derived_Class:Base_Class
    {
        sealed public override void Show()
        {
            Console.WriteLine("Sealed Method show");
        }
        public override void Disp()
        {
            Console.WriteLine("derived class Method disp");
        }
    }
    class D2:Derived_Class
    {
        //public override void Show() //Cannot Override bcoz it is sealed
        //{
        //    Console.WriteLine("Virtual Base Method show");
        //}
        public override void Disp() //if you not put oveeride its base class disp() method will be executed
        {
            Console.WriteLine("multilevel derived class Method disp");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Base_Class obj = new Base_Class();
            obj.Show();
            obj.Disp();
            Base_Class obj1 = new Derived_Class();
            obj1.Show();
            obj1.Disp();
            Base_Class obj2 = new D2();
            obj2.Show(); // "Sealed Method show" will print
            obj2.Disp();
        }
    }
}
