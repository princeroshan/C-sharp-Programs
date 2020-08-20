using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Note: This program will not work on 
// online compiler 
// Error: Unsafe code requires the `unsafe'  
// command line option to be specified 
// For its solution: 
// Go to your project properties page and 
// check under Build the checkbox Allow 
// unsafe code.
namespace PointerType
{
    class Program
    {
        static void Main(string[] args)
        {
            unsafe
            {
                // declare variable 
                int n = 10;

                // store variable n address  
                // location in pointer variable p 
                int* p = &n;
                Console.WriteLine("Value :{0}", n);
                Console.WriteLine("Address :{0}", (int)*p);
            }
            
        }
    }
}
