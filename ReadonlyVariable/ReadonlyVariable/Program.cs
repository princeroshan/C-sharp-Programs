using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadonlyVariable
{
    class Program
    {
        readonly int age;
        readonly int sal=10;
        int k = 10000;
        public Program() // Constructor
        {
            this.age = 266;//intialize can be done only in contructor or at the time of decalration
        }
        public Program(int x, int y)
        {
            this.sal = x;
            this.age = y;
            int k = 10000;
            Console.WriteLine("Inside Method Value:"+(sal + k));
        }
        static void Main(string[] args)
        {
            Program obj = new Program();
            Program obj2 = new Program(80000,45);
            Console.WriteLine("The Value is :"+(obj.age + obj.k));
            Console.WriteLine("The value of max is = " +obj.age + " "+obj.sal); //266 10
            Console.WriteLine("The value is = " + obj2.age + " " + obj2.sal);//8 4
            Console.ReadKey();
        }
    }
}
