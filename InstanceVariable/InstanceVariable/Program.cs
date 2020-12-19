using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InstanceVariable
{
    class Program
    {
        //instance variable declare inside class but outside block/Method/Constructor
        string name;
        int age;
        int marks;
       string msg= "Hii how are you?";
        string msg1= "Hii I am Fine";
        public void Show()
        {
            Console.WriteLine("Non-static Method Instance variable:"+ age);
        }

        static void Main(string[] args)
        {
            Program obj1 = new Program();
            Program obj2 = new Program();
            obj1.Show();
            // first object variable initialization
            obj1.name = "Prince";
            obj1.age = 28;
            obj1.marks = 600;

            // second object variable initialization
            obj2.name = "Samantha";
            obj2.age = 26;
            obj2.marks = 700;

            Console.WriteLine("First Object Name :" + obj1.name);
            Console.WriteLine("First Object Age :" + obj1.age);
            Console.WriteLine("First Object Marks :" + obj1.marks);
            Console.WriteLine("First Object Message :" + obj1.msg);
            Console.WriteLine();

            Console.WriteLine("Second Object Name :" + obj2.name);
            Console.WriteLine("Second Object Age :" + obj2.age);
            Console.WriteLine("Second Object Marks :" + obj2.marks);
            Console.WriteLine("Second Object Reply :" + obj2.msg1);
        }
    }
}
