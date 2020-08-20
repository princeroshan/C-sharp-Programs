using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstanctVariable
{
    class Program
    {
        //constant variable
        const float salary = 100000;

        // instance variable 
        int ins = 10;

        // static variable 
        static int st = 20;
        static void Main(string[] args)
        {
            const int abc = 1100;
            // creating object 
            Program obj = new Program();
            // displaying result 
            //for instance variable
            Console.WriteLine("The value of a is = " + obj.ins);

            // static variable 
            Console.WriteLine("The value of b is = " + Program.st+ "  "+abc);

            //constant variable
            Console.WriteLine("Salary :" + Program.salary);
            Console.ReadKey();
        }
    }
}
