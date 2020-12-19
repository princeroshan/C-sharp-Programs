using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structure
{
    public struct Person
    {
        public string Name;
        public int age;
        public int weight;
        public Details det;
    }
    //nested structure
    public struct Address
    {
        public string city;
        public string state;
    }
    public struct Details
    {
        public string mob_no;
        public string sex;
        public Address addr;
    }
    
    class Program
    {
        static void Main(string[] args)
        {
            Person p1;
            p1.Name = "Prince";
            p1.age = 28;
            p1.weight = 70;
            //nested struct declaration
            p1.det.mob_no = "78789787978";
            p1.det.sex = "Male";
            p1.det.addr.city = "Ranchi";
            p1.det.addr.state = "Jharkhand";
            Console.WriteLine("Name :" + p1.Name);
            Console.WriteLine("Age :" + p1.age);
            Console.WriteLine("Sex :" + p1.det.sex);
            Console.WriteLine("Weight :" + p1.weight);
            Console.WriteLine("Mobile No :" + p1.det.mob_no);
            Console.WriteLine("City :" + p1.det.addr.city);
            Console.WriteLine("State :" + p1.det.addr.state);
            Console.ReadKey();
        }
    }
}
