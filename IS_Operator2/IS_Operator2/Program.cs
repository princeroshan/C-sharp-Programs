using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IS_Operator2
{
    public class G1
    {

    }

    // taking a class  
    // derived from G1 
    public class G2 : G1
    {

    }
    public class G3
    {

    }
    class Program
    {
        static void Main(string[] args)
        {
            // creating an instance of class G1 
            G1 obj1 = new G1();

            // creating an instance of class G2 
            G2 obj2 = new G2();

            // checking whether 'obj1' is of type 'G1' 
            Console.WriteLine(obj1 is G1);

            // checking whether 'obj1' is of type Object class (Base class for all classes) 
            Console.WriteLine(obj1 is Object);

            // checking whether 'obj2' is of type 'G2' 
            Console.WriteLine(obj2 is G2);

            // checking whether 'obj2' is of type Object class (Base class for all classes) 
            Console.WriteLine(obj2 is Object);

            // checking whether 'obj2' is of type 'G1' it will return true as G2 is derived from G1 
            Console.WriteLine(obj2 is G2);

            // checking whether obj1 is of type G3 it will return false 
            Console.WriteLine(obj1 is G3);

            // checking whether obj2 is of type G3 it will return false 
            Console.WriteLine(obj2 is G3);
            Console.ReadKey();
        }
    }
}
