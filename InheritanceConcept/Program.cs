using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceConcept
{
    class Base_Class
    {
        public string name;
        public string subject;
        public Base_Class()
        {
            Console.WriteLine("Base Class Constructor Called");
        }
        public void getDetails(string n, string s)
        {
            this.name = n;
            this.subject = s;
            Console.WriteLine("Name :" + name + "Subject :" + subject);
        }
    }
    class Derived_Class:Base_Class
    {
        public Derived_Class()
        {
            Console.WriteLine("Derived Class Constructor Called");
        }
        public void getShow()
        {
            Console.WriteLine("Derived Class Method");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Base_Class obj2 = new Base_Class();
            obj2.getDetails("Prince", "CSE");
            Derived_Class obj = new Derived_Class();
            obj.getShow();//Derived class Method Called
            obj.getDetails("Neeraj", "Phy");// Base Clas Method Called
        }
    }
}
