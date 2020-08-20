using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IS_Operator
{
    class Author
    {

        // data members 
        public string name;
        public int rank;

        // method of Author class 
        public void details(string n, int r)
        {
            name = n;
            rank = r;
        }
    }

    class Work
    {

        // data members 
        public int articl_no;
        public int improv_no;

        // method of Work class 
        public void totalno(int a, int i)
        {
            articl_no = a;
            improv_no = i;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            // Creating objects of  
            // Author and Work class 
            Author a = new Author();

            a.details("Ankita", 5);

            Work w = new Work();

            w.totalno(80, 50);

            bool result;

            // Check 'a' is of Author  
            // type or not 
            // Using is operator 
            result = a is Author;
            Console.WriteLine("Is a is Author? : {0}", result);
            result = w is Work;
            Console.WriteLine("Is w is Work? : {0}", result); //true
            // Check w is of Author type 
            // using is operator 
            result = w is Author;
            Console.WriteLine("Is w is Author? : {0}", result); //false

            // Take the value of a is null 
            a = null;

            // Check null object 
            // Using is operator 
            result = a is Author;
            Console.WriteLine("Is a is Author? : {0}", result); //false
            Console.ReadKey();
        }
    }
}
