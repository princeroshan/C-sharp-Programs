using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Copy_Constructor
{
    class Program
    {
        private string months;
        private int year;
        //declaring copy constructor
        public Program(Program copycons)
        {
            months = copycons.months;
            year = copycons.year;
        }
        public Program(string m, int y)
        {
            this.months = m;
            this.year = y;
        }
        public string Details //properties in c# for accessing months and year
        {
            get
            {
                return "Month: " + months +
                         "\nYear: " + year.ToString();
            }
        }
        static void Main(string[] args)
        {
            Program obj = new Program("June", 1990);
            Program obj1 = new Program(obj);//copy variables from other object Program(obj)=Program(Program copycons)
            Console.WriteLine(obj1.Details);
            Console.ReadKey();
        }
    }
}
