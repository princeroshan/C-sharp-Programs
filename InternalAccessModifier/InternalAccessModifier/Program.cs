using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InternalAccessModifier
{ 
    class Complex
    {
        int real;
        int img;
        public void setData(int r, int n)
        {
            real = r;
            img = n;
        }
        public void dispData()
        {
            Console.WriteLine("Value of real :" + real);
            Console.WriteLine("Value of img :" + img);
        }
        //public int dispDataReal()
        //{
        //    return real;
        //}
        //public int dispDataImg()
        //{
        //    return img;
        //}
    }

    class Program
    {
        static void Main(string[] args)
        {
            Complex obj = new Complex();
            obj.setData(8,4);
            obj.dispData();
            //Console.WriteLine("Value of real :" + obj.dispData());
            //Console.WriteLine("Value of img :" + obj.dispDataImg());
        }
    }
}
