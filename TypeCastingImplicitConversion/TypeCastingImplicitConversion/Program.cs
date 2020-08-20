using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypeCastingImplicitConversion
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 500;
            float f = i;
            double d = f;
            long l = i;
            Console.WriteLine(i);
            Console.WriteLine(f);
            Console.WriteLine(d);
            Console.WriteLine(l);
            Console.ReadKey();
        }
    }
}
