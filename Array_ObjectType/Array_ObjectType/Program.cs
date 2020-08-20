using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_ObjectType
{
    class Circle
    {

        public int radius;

        // Definig Constructor 
        public Circle()
        {
            radius = 0;
        }

        // Method to set value of radius 
        public void setValue(int r)
        {
            radius = r;
        }

        // Method to calculate the  
        // area of the Circle 
        public double Area()
        {
            return (double)3.14 * radius * radius;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            // To declare an array of two objects 
            Circle[] circleArray = new Circle[2];

            // Initialize the objects 
            circleArray[0] = new Circle();
            circleArray[1] = new Circle();

            // to set values for the radius 
            circleArray[0].setValue(1);
            circleArray[1].setValue(2);

            // for loop to display areas 
            for (int i = 0; i < circleArray.Length; i++)
            {
                Console.Write("Area of circle with radius " + (i + 1));
                Console.Write(" is " + circleArray[i].Area() + "\n");
            }
        }
    }
}
