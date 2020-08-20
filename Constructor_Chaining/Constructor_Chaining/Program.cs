using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor_Chaining
{
    class Program
    {
        private int Length, Height;
        private double Width;

        // Default Constructor 
        public Program()
        {
            Console.WriteLine("Default Constructor Invoked");
        }
        // The constructor calls the Default constructor 
        public Program(int l, double w) : this()
        {
            Console.WriteLine("Parameterized Constructor in 2nd Constructor");
            // assigning value of 'Length'and 'Width' 
            Length = l;
            Width = w;
        }
        // The constructor call the parameterized constructor 
        public Program(int l, double w, int h) : this(l, w)
        {
            Console.WriteLine("Parameterized Constructor in 3rd Constructor");
            // assign value of 'Height' 
            Height = h;
        }
        // Public Method to calculate volume 
        public double Volume()
        {
            return (Length * Width * Height);
        }
    static void Main(string[] args)
        {
            // Invoking 3rd Constructor here Constructor chaining came into existence 
            Program obj = new Program(10, 20.5, 30);
            double res = obj.Volume();
            // calling the 'Volume' Method 
            Console.WriteLine("Volume is : {0}", res);
            Console.ReadKey();
        }
    }
}
