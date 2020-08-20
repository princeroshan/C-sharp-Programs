using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertiesVariable
{
    public class C1
    {
        public string name;
        public int rn = 20;
        private int marks=500;
        
        public int Marks
        {
            get
            {
                return marks;
            }
            set
            {
                marks = value;
            }
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            C1 obj = new C1();
            obj.name = "Prince";
            // calls set accessor of the property Name, and pass "800" as value of the standard field 'value'.
            
            obj.Marks = 800;
            Console.WriteLine("Name: " + obj.name);              //Prince
            Console.WriteLine("Roll: " + obj.rn);                //20
            // displays 800, Calls the get accessor of the property Name.
            Console.WriteLine("Marks: " + obj.Marks);           //800 if comment obj.Marks=800; 500 will be printed
            Console.ReadKey();
        }
    }
}
