using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor_ArgsType
{
    class Program
    {
        int x, y;
        string name;
        int roll;
        public Program(int m, int n)
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
            Console.WriteLine("First Constructor (int , int) :"+x+" "+y+" "+"Sum :"+(x+y));
        }
        public void show1()
        {
            Console.WriteLine("Second Constructor (string , int) :" +"Name :"+name+" "+"Roll :"+roll);
        }
        static void Main(string[] args)
        {
            Program obj = new Program(5, 6);
            obj.show();
            Program obj1 = new Program("Prince", 10);
            obj1.show1();
            Console.ReadKey();

        }
    }
}
