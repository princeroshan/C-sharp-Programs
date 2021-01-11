using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticVariable
{
    class Program
    {
        // static variable declared with static keyword
        static string name = "Prince";
        static int age=25;
        static string message;
        //non-static/instance variable
        public int instavar = 12345;
        //Non-Static Method
        public int add()
        {
            age = age + 5; // static variable accessed and gets updated in non-static method
            return age;
        }
        //Static Method
        public static int Foo()
        {
            Program obj = new Program();
            obj.instavar++; //instance variable accessed by object creation
            int reg = 1050;// static data member
            Console.WriteLine("Instance Variable Called inside static method:"+obj.instavar);
            return reg;
           
        }
        public static void Main(string[] args)
        {
            //all data member under static method are static variable like resage, regmain
            Program obj=new Program();//Object Creation is necessary for non-static method and data member access

            obj.instavar = 1001;//instance variable called and updated

            int resage=obj.add();//calling non-static method, need instance creation

            int regmain=Foo(); //calling static method, no need instance creation.

            message = "Static message"; //updating static member message

            Console.WriteLine("Name :" + Program.name + " " + "Age :" + Program.age+" "+"Message:"+message);
            //OR Use//
            //Console.WriteLine("Name :" + name + " " + "Age :" + age);
            Console.WriteLine(resage+" "+ regmain);
            Console.WriteLine("Instance Variable Called inside Main method:" + obj.instavar);
            Console.ReadKey();
              
        }
    }
}
