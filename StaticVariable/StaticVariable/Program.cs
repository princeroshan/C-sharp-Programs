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
        static double salary;
        static string name = "Prince";
        static int age=25;
        //Method
        public int add()
        {
            age=age+5; // Now, age=30
            return age;
        }
        //Main Method/Driver Method
        static void Main(string[] args)
        {
            Program obj=new Program();
            int resage=obj.add();
           
            Program.salary = 30000;
            Program.age = 28; //here age=30 gets change to 28
            Console.WriteLine("Name :" + Program.name + " " + "Age :" + Program.age + " " + "Salary :" + Program.salary);
            //OR//
            Console.WriteLine("Name :" + name + " " + "Age :" + age + " " + "Salary :" + salary);//age=28

            Console.WriteLine(resage); //30
            Console.ReadKey();
              
        }
    }
}
