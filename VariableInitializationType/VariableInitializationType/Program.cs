using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VariableInitializationType
{
    class Program
    {
        int y;
        static void Main()
        {
            //compile time Initialization
            int x = 10; 
            Console.WriteLine("local variable value :{0}", x); //when use "," use {0}

            Program obj = new Program();
            Console.WriteLine("Class Level Variable :"+ obj.y); //use + when no use "," and {0}
        }
    }
}
