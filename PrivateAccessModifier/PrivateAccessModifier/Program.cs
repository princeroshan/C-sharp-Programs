using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrivateAccessModifier
{
    class A
    {
        private int marks;
        private int age=50;
        public void setMarks(int m)
        {
            this.marks = m;
        }
        public int getMarks()
        {
            return marks;
        }
    }
    class B : A
    {
        public void showMarks()
        {
           // Console.WriteLine("Marks:"+marks); //error not accessible

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            A obj = new A();
            obj.setMarks(800);
            //obj.age = 40; cannot set
            Console.WriteLine(obj.getMarks());
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
