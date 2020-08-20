using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProtectedAccessModifier
{
    class X
    {
        protected int x;
        public X()
        {
            this.x = 20;
        }
    }
    class Y : X //inheritence
    {
        public int getValueX()
        {
            return x;  //'x' is accessible to derived class
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            X obj1 = new X();
            Y obj2 = new Y();
            //Console.WriteLine("Value of X in object 1-X :"+obj1.x); //due to protection level x is unaccessible
            Console.WriteLine("Value of X in object 1-Y :"+obj2.getValueX());
        }
    }
}
