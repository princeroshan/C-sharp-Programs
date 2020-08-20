using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AS_Operator
{
    class Program
    {
        static void Main(string[] args)
        {
            string str1 = "Hello World!";
            Object obj1 = str1;
            string str2 = obj1 as string;
            if (str2 != null)
            {
                Console.WriteLine("Successfully Cast1");
                Console.WriteLine(str2);
            }
            //cast object obj1 to list type
            List<string> mylist = obj1 as List<string>;
            if (mylist!=null)
            {
                Console.WriteLine("Successfully Cast2");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Not Successfull");
                Console.ReadKey();
            }
        }
    }
}
