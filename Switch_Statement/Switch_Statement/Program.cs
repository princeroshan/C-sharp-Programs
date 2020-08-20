using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Switch_Statement
{
    class Program
    {
        static void Main(string[] args)
        {
            string month = Console.ReadLine();
            switch(month)
            {
                case "January":
                    Console.WriteLine("January Chosen");
                    break;

                case "March":
                    Console.WriteLine("March chosen");
                    break;

                case "April":
                    Console.WriteLine("April Chosen");
                    break;

                default:
                    Console.WriteLine("No match found");
                    break;
                    
            }
            Console.ReadKey();
        }
    }
}
