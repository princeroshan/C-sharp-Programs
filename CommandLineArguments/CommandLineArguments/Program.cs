using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandLineArguments
{
    class Program
    {
        static void Main(string[] args)
        {

            if (args.Length > 0)
            {
                Console.WriteLine("Argument Passed by User is: ");
                foreach (object obj in args)
                {
                    Console.WriteLine(obj);
                }
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("NO Argument Passed by User");
                Console.ReadKey();
            }
        }
    }
}
