using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicKeyWord
{
    class Program
    {
        static void Main() //when passing command line argument use string[] args
        {
            addStr("Prince", "Roshan");
            addStr(1, 2);
            addStr(10.25, 5);
            addStr("Prince", 2);
            addStr("Prince", false);
            //addStr(5, false); it will give unhandled exception

            // Dynamic variables 
        dynamic value1 = "GeeksforGeeks"; //Type string
            //value1=5; now value will be of type int32
        dynamic value2 = 123234; 
        dynamic value3 = 2132.55; 
        dynamic value4 = false; 
        // Get the actual type of  
        // dynamic variables 
        // Using GetType() method 
        Console.WriteLine("Get the actual type of value1: {0}", 
                                  value1.GetType().ToString()); 
  
        Console.WriteLine("Get the actual type of value2: {0}", 
                                  value2.GetType().ToString()); 
  
        Console.WriteLine("Get the actual type of value3: {0}", 
                                  value3.GetType().ToString()); 
  
        Console.WriteLine("Get the actual type of value4: {0}",  
                                  value4.GetType().ToString());
        }
        public static void addStr(dynamic p1, dynamic p2)
        {
            Console.WriteLine(p1+p2);
            Console.ReadKey();
        }
    }
}
