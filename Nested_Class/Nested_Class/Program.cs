using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nested_Class
{
    // Outer class 
    public class Outer_class
    {
        int marks = 400; //Bydefault data members are private
        // Method of outer class 
        public void method1()
        {
            Console.WriteLine("Outer class method");
            //Calling static method in outer class
            //Inner_class.method3();
        }
        // Inner class 
        public class Inner_class
        {

            // Method of inner class 
            public void method2()
            {
                Console.WriteLine("Inner class Method");
            }
            public static void method3()
            {
                Outer_class obj = new Outer_class();
                Console.WriteLine("Outer Class Private value in static method :"+obj.marks);//accessing outer class data member
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            // Create the instance of outer class 
            Outer_class obj1 = new Outer_class();
            obj1.method1();

            // This statement gives an error because you are not allowed to access inner  
            // class methods with outer class objects 
            // obj1. method2(); 

            // Creating an instance of inner class 
            Outer_class.Inner_class innerobj = new Outer_class.Inner_class();
            innerobj.method2();
            //accessing static method of inner class
            Outer_class.Inner_class.method3();
            Console.ReadKey();
        }
    }
}
