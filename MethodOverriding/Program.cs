using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverriding
{
    class baseClass

    {
        public void show()
        {
            Console.WriteLine("Base class");
        }
    }

    // derived class name 'derived'
    // 'baseClass' inherit here
    class derived : baseClass
    {

        // overriding
        new public void show()
        {
            Console.WriteLine("Derived class");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            // 'obj' is the object of
            // class 'baseClass'
            baseClass obj = new baseClass();


            // invokes the method 'show()'
            // of class 'baseClass'
            obj.show();

            obj = new derived();

            // it also invokes the method 
            // 'show()' of class 'baseClass'
            obj.show();
            derived obj1 = new derived();
            obj1.show();
        }
    }
}
