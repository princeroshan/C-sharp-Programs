using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PublicAccessModifier
{
    class Program
    {
        public int rollno;
        public int marks;
        public string name;

        // Constructor 
        public Program(int r, int m, string n)
        {
            this.rollno = r;
            this.marks = m;
            this.name = n;
        }

        public string getName()
        {
            return name;
        }

        public int getRoll()
        {
            return rollno;
        }

        public int getMarks()
        {
            return marks;
        }
        static void Main(string[] args)
        {
            Program obj = new Program(12,80,"Prince");
            //obj.name = "Prince";
            //obj.rollno = 12;
            //obj.marks = 80;

            // Displaying details directly 
            // using the class members 
            // accessible through another method 
            Console.WriteLine("Displaying details directly using the class members accessible through another method");
            Console.WriteLine("Name :"+obj.name);
            Console.WriteLine("Roll No :"+obj.rollno);
            Console.WriteLine("Marks :"+obj.marks+"\r\n");

            // Displaying details using  
            // member method also public
            Console.WriteLine("Displaying details using member method also public");
            Console.WriteLine("Name :" + obj.getName());
            Console.WriteLine("Roll No :" + obj.getRoll());
            Console.WriteLine("Marks :" + obj.getMarks());

        }
    }
}
