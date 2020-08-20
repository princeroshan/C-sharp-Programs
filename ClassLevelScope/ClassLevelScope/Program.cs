using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLevelScope
{
    class Program
    {
        int a = 10;
        private int b = 50;
        protected string c = "Prince";
        public void showVar()
        {
            int z = 50; //Method Level Variable// cannot access outside this
            Console.WriteLine("Integer a: " + a);
            Console.WriteLine("Private value b: " + b);
            Console.WriteLine("Protected value c: " + c + "\r\n");
            Console.WriteLine("Method Level value z: " + z +"\r\n");
            //Block Level
            for (int i=0;i<5;i++)
            {
                Console.WriteLine("Block Level value i: " + i);
            }
        }
        static void Main(string[] args)
        {
            Program obj = new Program();
            obj.showVar();
            Console.WriteLine();
            Console.WriteLine("Class Level value in Static Method a: " + obj.a);
            Console.WriteLine("Class Level value in Static Method b: " + obj.b);
            Console.WriteLine("Class Level value in Static Method c: " + obj.c);

        }
    }
}
