using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrivateMemberAccess
{
    class Abc
    {
        private int id = 100;
        private int marks = 500;
        public int ShowId()
        {
            return id;   
        }
        public int ShowMarks()
        {
            return marks;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Abc obj = new Abc();
            int id2 = obj.ShowId();
            int marks2 = obj.ShowMarks();// only you can access but can't update for that you have to use get set properties.
            
            Console.WriteLine("Private Member Shown :" + id2 + " " + marks2);
        }
    }
}
