using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor_NumberArgs
{
    class Program
    {
        int x, y, z;
        string name;
        int roll;
        public Program(int m, int n, int o)
        {
            x = m;
            y = n;
        }
        public Program(string n, int r)
        {
            name = n;
            roll = r;
        }
        public void show()
        {
            Console.WriteLine("First Constructor(3 argument) :" + x + " " + y + " " + z);
        }
        public void show1()
        {
            Console.WriteLine("Second Constructor (2 argument) :" + "Name :" + name + " " + "Roll :" + roll);
        }
        static void Main(string[] args)
        {
            Program obj = new Program(5, 6, 10);
            obj.show();
            Program obj1 = new Program("Prince", 10);
            obj1.show1();
            Console.ReadKey();
        }
    }
}
