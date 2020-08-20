using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace for_loop_pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            //inverted pyramid pattern
            for (int i = n; i >= 1; i--)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            //pyramid pattern
            for (int k = 0; k <= n; k++)
            {
                for (int m = 0; m <= k; m++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            //Continue statement
            for (int i = 1; i <= 3; i++)
            {
                if (i == 2)
                {
                    continue;
                }
                Console.WriteLine("GeeksforGeeks" + i);
            }
            //multiple initializer in single for loop
            for (int x = 0, y = 0; x+y<n;x++,y++)
            {
                Console.WriteLine("Value of x:{0}, y:{1}", x, y);
            }
            Console.ReadKey();
        }
    }
}
