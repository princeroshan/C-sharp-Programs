using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace foreach_loop
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> mylist = new List<string>();
            mylist.Add("Hello");
            mylist.Add("Programmers");
            mylist.Add("I");
            mylist.Add("am");
            mylist.Add("Back");
            foreach(var a in mylist)
            {
                Console.WriteLine(a);
                
            }
            int[] arr = new int[5] { 1, 2, 3, 4, 5 };
            foreach (var b in arr)
            {
                Console.Write(b);

            }
            Console.ReadKey();
        }
    }
}
