using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Object_CreationType
{
    class Triangle
    {

        public int side, altitude;
        // Not defining a constructor 

        // Method to calculate area 
        // of the Triangle 
        public double Area()
        {
            return (double)0.5 * side * altitude;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            // Creating an object using new calls the default constructor 
            Triangle tri1 = new Triangle();

            // Only creates a reference of type Triangle 
            Triangle tri2;

            // Displaying area of tri1 
            Console.WriteLine("Area of tri1 is "+ tri1.Area()); //0.5*0*0

            // Assigns the reference to tri1 
            tri2 = tri1;

            // Making changes in tri2 
            tri2.side = 5;
            tri2.altitude = 7;

            // Displaying area of tri1 Changes made in the reference tri2 are reflected in tri1 also 
            Console.WriteLine("Area of tri1 is "+ tri1.Area());//0.5*5*7
            Console.ReadKey();
        }
    }
}
