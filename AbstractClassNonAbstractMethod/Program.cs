using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassNonAbstractMethod
{
    public abstract class Abc
    {
        public abstract int MultiplyTwoNo(int num1, int num2);
        public int AddTwoNo(int n1, int n2)
        {
            return n1 + n2;
        }
    }
    class GFG : Abc
    {

        public override int MultiplyTwoNo(int num1, int num2)
        {
            return num1 * num2;
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            GFG obj = new GFG();
            int res = obj.MultiplyTwoNo(9, 6);
            Console.WriteLine("Multiplication of Numbers are :" + res);
            Abc obj1 = new GFG(); //Or GFG obj1 = new GFG();
            Console.WriteLine("Addition of two numbers :"+obj1.AddTwoNo(10,20));
        }
    }
}
