using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AS_Operator2
{
    class Geeks1
    {

    }
    class Geeks2
    {

    }
    class Program
    {
        static void Main(string[] args)
        {
            object[] obj = new object[5];
            obj[0] = new Geeks1();
            obj[1] = new Geeks2();
            obj[2] = "C#";
            obj[3] = 334.5;
            obj[4] = null;

            for (int j = 0; j < obj.Length; ++j)
            {

                // using as operator 
                string str = obj[j] as string;

                Console.Write("{0}:", j);

                // checking for the result 
                if (str != null)
                {
                    Console.WriteLine("'" + str + "'");
                    Console.ReadKey();
                }
                else
                {
                    Console.WriteLine("Is is not a string");
                    Console.ReadKey();
                }
            }
        }
    }
}
