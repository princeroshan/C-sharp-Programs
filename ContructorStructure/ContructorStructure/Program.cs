using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContructorStructure
{
    public struct Coordinate
    {
        public int x;
        public int y;
        public Coordinate(int x1, int y1)
        {
            this.x = x1;
            this.y = y1;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Coordinate obj = new Coordinate(8, 9);
            Console.WriteLine(obj.x);
            Console.WriteLine(obj.y);
            Console.ReadKey();
        }
    }
}
