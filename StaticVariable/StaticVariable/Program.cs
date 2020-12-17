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
        static double salary=40000;
        static string name = "Prince";
        static int age=25;
        static string message;
        //Non-Static Method
        public int add()
        {
            age=age+5; // Now, age=30
            return age;
        }
        //Main Method
        static void Main(string[] args)
        {
            Program obj=new Program();
            int resage=obj.add();

            //static variable initialization
            Program.message = "Static message";
            Console.WriteLine("Name :" + Program.name + " " + "Age :" + Program.age + " " + "Salary :" + Program.salary+" "+"Message:"+message);
            //OR//
            Console.WriteLine("Name :" + name + " " + "Age :" + age + " " + "Salary :" + salary);

            Console.WriteLine(resage); //30
            Console.ReadKey();
              
        }
    }
}
