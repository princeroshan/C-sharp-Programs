using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypeCastingExplicit
{
    class Program
    {
        static void Main(string[] args)
        {
            double d = 765.800;
            int i = Convert.ToInt32(d); //Explicit conversion Type
            int j=(int) d; //Explicit conversion Type
            float f = (float)d; //Explicit conversion Type
            Console.WriteLine(d);
            Console.WriteLine(i);
            Console.WriteLine(j);
            Console.WriteLine(f);
            Console.ReadKey();
            //Byte>short>int>long>float>double
            // lower data type to higher data type implicetely converted or automatic convereted
            //from higher to lower i.e double to int explicit conversion occurs.
        }
    }
}
