using System;

namespace SealedClass
{
    sealed class Program
    {
        public int Add(int a, int b)
        {
            int res = a + b;
            return res;
        }
        static void Main(string[] args)
        {
            Program obj = new Program();
            
            Console.WriteLine("Addition"+ obj.Add(10,20));
        }
    }
}
