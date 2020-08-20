using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Static_Constructor
{
   class Program
    {
        //It is invoked before the first instance constructor is run.
        static Program()
        {
            Console.WriteLine("Example of Static Constructor");
        }
        //instance constructor
        public Program(int j)
        {
            Console.WriteLine("Instance Constructor " + j);
        }
        //instance method; instance means class
        public string g1_detail(string name,string branch)
        {
            return ("Name " + name+" "+"Branch:"+branch);
        }
        static void Main(string[] args)
        {
            // Here Both Static and instance 
            // constructors are invoked for 
            // first instance 
            Program obj1 = new Program(1);

            Console.WriteLine(obj1.g1_detail("Sunil", "CSE"));

            // Here only instance constructor 
            // will be invoked 
            Program obj2 = new Program(2);

            Console.WriteLine(obj2.g1_detail("Sweta", "ECE"));
            Console.ReadKey();
        }
    }
}
