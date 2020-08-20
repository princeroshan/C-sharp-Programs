using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParamsDemo
{
    class Program
    {
        public int Add(params int[] ListNumbers)
        {
            int total = 0;
            foreach(int i in ListNumbers)
            {
                total += i;
            }
            return total;
        }
        public static int multiplyNo(params int[] numbers)
        {
            int total = 1;
            foreach (int j in numbers)
            {
                total *= j;
            }
            return total;
        }
        //object type
        public void result(params object[] array)
        {
            for(int k=0;k<array.Length;k++)
            {
                Console.WriteLine("Object Type:"+array[k]);
            }
        }
        public static void Main(string[] args)
        {
            Program obj = new Program();
            obj.result("Geek", "For", "Geeks", 10, "100");
            int res = obj.Add(5, 5, 25, 9);// non static method
            int mult = multiplyNo(4, 5, 10);//static method
            Console.WriteLine("This is non static method value :"+res);
            Console.WriteLine("This is static method value :" + mult);
            Console.ReadKey();
        }
        
    }
}
