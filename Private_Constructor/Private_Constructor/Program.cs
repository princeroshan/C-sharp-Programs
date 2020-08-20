using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Private_Constructor
{
    class Program
    {
        public static int count;
        private Program() //Private Constructor
        {

        }
        public static int countMethod()
        {
            return ++count;
        }
        static void Main(string[] args)
        {
            //You cannot create object of private constructor
            //so always used with static method and data members
            Program.count = 99;
            Program.countMethod();
            Console.WriteLine(count);//100

            // Accessing without any instance of the class 
            Program.countMethod();
            Console.WriteLine(count);//101
            Program.countMethod();
            Console.WriteLine(count);//102
            Console.ReadKey();
        }
    }
}
