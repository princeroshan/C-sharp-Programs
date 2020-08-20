using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enumeration
{
    enum month
    {
        jan,
        feb,
        march,
        april,
        may
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The value of Jan :" + month.jan);
            Console.WriteLine("The value of feb :" + month.feb);
            Console.WriteLine("The value of march :" + month.march);
            Console.WriteLine("The value of april :" + month.april);
            Console.WriteLine("The value of may :" + month.may);
            //integer type gives value
            Console.WriteLine("The value of Jan :" + (int)month.jan);
            Console.WriteLine("The value of feb :" + (int)month.feb);
            Console.WriteLine("The value of march :" + (int)month.march);
            Console.WriteLine("The value of april :" + (int)month.april);
            Console.WriteLine("The value of may :" + (int)month.may);
            Console.ReadKey();
        }
    }
}
