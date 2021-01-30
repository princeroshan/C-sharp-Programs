using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrixArrayImplementation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("No of Rows entered = ");
            int r = Convert.ToInt32(Console.ReadLine());

            Console.Write("No of Columns entered = ");
            int c= Convert.ToInt32(Console.ReadLine());
            int[,] arr1 = new int[r,c];
            int[,] arr2 = new int[c,r];
            //Fill the array
            for (int i = 0; i < r; i++)
            {
                for (int j = 0; j < c; j++)
                {
                    Console.Write("[{0}],[{1}] : ", i, j+" ");
                    arr1[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            //show the array
            Console.WriteLine("Matrix before Transpose:");
            for (int i = 0; i < r; i++)
            {
                Console.WriteLine();
                for (int j = 0; j < c; j++)
                    Console.Write("{0}", arr1[i, j]+" ");
            }
            Console.WriteLine();
            //transpose the matrix
            for (int i = 0; i < r; i++)
            {
                for (int j = 0; j < c; j++)
                {

                    arr2[j, i] = arr1[i, j];
                }
            }

            Console.WriteLine("Matrix after Transpose: ");
            //show the transpose matrix
            for (int i = 0; i < c; i++)
            {
                Console.WriteLine();
                for (int j = 0; j < r; j++)
                {
                    Console.Write(arr2[i,j]+" ");
                }
            }
        }
    }
}
