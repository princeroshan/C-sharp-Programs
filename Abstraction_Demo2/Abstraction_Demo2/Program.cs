using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction_Demo2
{
    // C# program to show the working of abstract class with the get and set accessors 
    abstract class absClass
    {
        protected int myNumber;
        public abstract int numbers
        {
            get;
            set;
        }
    }
    class absDerived : absClass
    {
        // Implementing abstract properties 
        public override int numbers
        {
            get
            {
                return myNumber;
            }
            set
            {
                myNumber = value;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            absDerived d = new absDerived();
            d.numbers = 5;
            Console.WriteLine(d.numbers);
        }
    }
}
