using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enumeration2
{
    class Program
    {
        public enum shapes
        {
            circle,
            square
        }
        public void area(int val, shapes s)
        {
            if((int)s==0)
            {
                Console.WriteLine("Area of Circle :" + (3.14 * val * val));
                Console.ReadKey();
            }
            else if((int)s==1)
            {
                Console.WriteLine("Area of Square :" + (val * val));
                Console.ReadKey();
            }
        }
        static void Main(string[] args)
        {
            Program obj = new Program();
            obj.area(3, shapes.circle);
            obj.area(4, shapes.square);
        }
    }
}
