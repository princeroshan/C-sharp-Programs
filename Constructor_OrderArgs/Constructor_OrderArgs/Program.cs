using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor_OrderArgs
{
    class Program
    {
        int id;
        string name;
        float salary;
        public Program(int i, string n, float s)
        {
            id = i;
            name = n;
            salary = s;
        }
        public Program(string n, float s, int i)
        {
            id = i;
            name = n;
            salary = s;
        }
        public void show()
        {
            Console.WriteLine("First Constructor(order int,string,float) :" + "ID :" + id+" "+ "Name :" + name + " " + "Salary :" + salary);
        }
        public void show1()
        {
            Console.WriteLine("Second Constructor (order string,float,int) :" + "Name :" + name + " " + "Salary :" + salary+" "+"ID :"+id);
        }
        static void Main(string[] args)
        {
            Program obj = new Program(5, "Prince", 500000);
            obj.show();
            Program obj1 = new Program("Samantha", 40000,9);
            obj1.show1();
            Console.ReadKey();
        }
    }
}
