using System;

namespace ObjectClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Object obj = new Object();
            Object obj1 = new Object();
            Object obj2 = new Object();
            obj = "Manoj";
            obj1 = "Suresh";
            obj2="Manoj";
            Console.WriteLine(obj.Equals(obj2)); //true
            Console.WriteLine(obj.Equals(obj1)); //false
            Console.WriteLine(Equals(obj,obj1)); //false
            int i = 10;
            Type t1 = obj.GetType();
            Type t2 = obj.GetType();
            Console.WriteLine("Object Type");
            Console.WriteLine("Base Type"+t1.BaseType);
            Console.WriteLine("Name"+t1.Name);
            Console.WriteLine("FullName"+t1.FullName);
            Console.WriteLine("Namespace"+t1.Namespace);
            Console.WriteLine("Integer Type");
            Console.WriteLine("Base Type" + t2.BaseType);
            Console.WriteLine("Name" + t2.Name);
            Console.WriteLine("FullName" + t2.FullName);
            Console.WriteLine("Namespace" + t2.Namespace);
            Console.ReadKey();
        }
    }
}
