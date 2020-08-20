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
    }
    //nested structure
    public struct Details
    {
        public string Country;
    }
    struct Address
    {
        public string city;
        public string state;
        public Details d1;
    }
    class Program
    {
        static void Main(string[] args)
        {
            Person p1;
            p1.Name = "Prince";
            p1.age = 28;
            p1.weight = 70;
            Console.WriteLine("Name :" + p1.Name);
            Console.WriteLine("Age :" + p1.age);
            Console.WriteLine("Weight :" + p1.weight);

            //nested struct declaration
            Address a1;
            a1.city = "Ranchi";
            a1.state = "Jharkhand";
            a1.d1.Country = "India";
            Console.WriteLine("City :" + a1.city);
            Console.WriteLine("State :" + a1.state);
            Console.WriteLine("Country :" + a1.d1.Country);
            Console.ReadKey();
        }
    }
}
