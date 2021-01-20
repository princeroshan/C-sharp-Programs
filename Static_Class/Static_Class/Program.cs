using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Static_Class
{
   public static class Calculator
    {
        private static int _resultStorage = 0;

        public static string Type = "Arithmetic";
        public static int Sum(int num1, int num2)
        {
            return num1 + num2;
        }
        public static void Store(int result)
        {
            _resultStorage = result;
            Console.WriteLine("Result :"+_resultStorage);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int res=Calculator.Sum(10, 20);
            Calculator.Store(res);
            Console.WriteLine("Sum :" + res);
            Console.WriteLine("Type :" + (Calculator.Type));
            Calculator.Type = "Scalar";
            Console.WriteLine("Type :" + (Calculator.Type));
            Console.ReadKey();

        }
    }
}
