using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VariableRuntimeInitialzation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Runtime Initialization: Please Enter Value");
            int x=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Value:"+x);
        }
    }
}
