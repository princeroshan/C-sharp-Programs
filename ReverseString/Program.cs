using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseString
{
    class Program
    {
        void printReverseString(string str)
        {
            string rev = "";
            int len = str.Length - 1;
            Console.Write("Reverse String :");
            while (len>=0)
            {
                rev = rev + str[len];
                len--;
            }
            Console.WriteLine(rev);
        }
        static void Main(string[] args)
        {
            string mystr = "Prince";
            Console.WriteLine("Given String :"+mystr);
            Program obj = new Program();
            obj.printReverseString(mystr);
        }
    }
}
