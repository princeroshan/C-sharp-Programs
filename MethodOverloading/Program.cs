using System;

namespace MethodOverloading
{
    class Program
    {
        public int Show(int a, int b)
        {
            int res = a + b;
            return res;
        }
        public void Show(int a, int b, int c)//no of parameter
        {
            Console.WriteLine(a * b * c);
        }
        public void Show(int a, string b, double c)
        {
            Console.WriteLine(a + b + c);
        }
        public void Show(double c, string b, int a)//order and datatype
        {
            Console.WriteLine(a+ b + c);
        }
        static void Main(string[] args)
        {
            Program obj = new Program();
            Console.WriteLine(obj.Show(10,20));
            obj.Show(10, 20, 3);
            obj.Show(10, "Prince", 3.0d);
            obj.Show(5.0d, "Mohit", 3);
        }
    }
}
