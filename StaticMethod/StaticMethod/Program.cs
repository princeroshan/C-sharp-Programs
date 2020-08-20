using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticMethod
{
    class Abc
    {
        static int marks;
        static int age = 56;
        static string name;
        public static void showName()
        {
            name="Prince";
            Console.WriteLine("Name :" + name);
        }
        public static int showMarks(int m) //public is neccessary to available it in main class
        {
           marks = m;
           return marks;
        }
        public static void showAge() //public is neccessary to available it in main class
        {
           Console.WriteLine("Age :" + age);
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Abc.showName();
            Abc.showAge();
            Console.WriteLine("Marks :" + Abc.showMarks(600));
            Console.ReadKey();
        }
    }
}
