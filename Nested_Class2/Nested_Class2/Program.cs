using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Private_Nested_Class
{
    public class Outer_class
    { 
        //outer class data member
        private int number = 200;
        public int number2 = 300;

        //outer class method
        public void outerMethod()
        {
            Inner_class obj = new Inner_class();
            //accessing private member of inner class
            //obj.a2 = 600;  to set a value to 'a'
            Console.WriteLine("Private Member of Inner Class:" + obj.a2);
            //when innerMethod is non-static
            obj.innerMethod2();
            //when innerMethod is static
            Outer_class.Inner_class.innerMethod();
            Console.ReadKey();
        }
        // Inner class 
        private class Inner_class
        {
            private int a = 400;
            public int a2 //to send private member to outer class
            {
                get => a;
                //get { return a; }
                //set
                //{
                //    a = value;
                //} use it when you want to change value of 'a'
            }
            public static void innerMethod()
            { 
                Inner_class innerobj1 = new Inner_class();
                //accessing private member in static method
                Console.WriteLine("Private Member in static Inner Method :"+ innerobj1.a); 

                Outer_class outerobj = new Outer_class();
                //accessing private member of Outer Class
                Console.WriteLine("Outer Class Private Member :"+outerobj.number);
                Console.WriteLine("Outer Class Member :" + outerobj.number2);
            }
            public void innerMethod2()
            {
                Console.WriteLine("Inner non-static Method invoked");
            }
        }
        
    }
    class Program
    {
        public static void Main(string[] args)
        {
            Outer_class obj = new Outer_class();
            obj.outerMethod(); //accessing method of inner class using outerclass method2
            
        }
    }
}
