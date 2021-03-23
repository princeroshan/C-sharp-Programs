using System;

namespace ObjectReturnMethod
{
    class Example
    {
        private string str;
        public void setData(string st)
        {
            str = st;
        }
        public void Display()
        {
            Console.WriteLine("String is :" + str);
        }
        public Example ObjectMethodEx(Example obj)
        {
            Example ex = new Example();
            ex.str = str+" " + obj.str; // to access str we have to create instance of class
            return ex; //returns object
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Example ob1 = new Example();
            ob1.setData("Geeks");
            Example ob2 = new Example();
            ob2.setData("For Geeks");
            Example ob3 = ob1.ObjectMethodEx(ob2);
            ob1.Display();
            ob2.Display();
            ob3.Display();
        }
    }
}
