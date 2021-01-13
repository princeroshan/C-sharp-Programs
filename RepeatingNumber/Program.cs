using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepeatingNumber
{
    class Program
    {
        static void printRepeatedNumber(int[] arr,int size) //size=9
        {
            Console.WriteLine();
            Console.WriteLine("Repeated numbers are :");
            for (int i=0;i<size;i++) //size=9
            {
                for(int j=i+1;j<size;j++)
                {
                    if(arr[i]==arr[j])
                    {
                        Console.Write(" "+arr[i] + " ");
                    }
                }
            }
        }
        static void Main(string[] args)
        {
            int[] arr_no = {4,2,5,8,8,4,1,5,6 };
            int arr_size = arr_no.Length;
            Console.Write("Given Numbers are :");
            foreach (var n in arr_no)
            {
                Console.Write(" "+n+" ");
            }
            printRepeatedNumber(arr_no, arr_size);
        }
    }
}
