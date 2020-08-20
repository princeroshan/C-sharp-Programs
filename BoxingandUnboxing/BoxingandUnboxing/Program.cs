using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoxingandUnboxing
{
    class Program
    {
        static void Main(string[] args)
        {
            //boxing  means conversion of Value Type(Char, Int,etc) into References Type(Object)
            int num = 23;
            Object obj = num; //Boxing
            num = 100;
            string obj1="String";
            string obj2=obj1;
            obj1="New String";// this will change object 1 but object 2 will be last value of object 1

            Console.WriteLine("Object 1  : {0}", obj1);
            Console.WriteLine("Object 2- contains Object 1 : {0}", obj2);

            Console.WriteLine("Value - type value of num is : {0}", num);
            Console.WriteLine("Object - type value of obj is : {0}", obj);

            //Unboxing  means conversion of References Type(Object) into Value Type(Char, Int,etc)

            int i = (int)obj; //Unboxing 
            // Display result 
            Console.WriteLine("Value of ob object is : " + obj);
            Console.WriteLine("Value of i is : " + i);
            Console.ReadKey();
        }
    }
}
