using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int num, m, flag = 0;
            Console.Write("Enter the Number to check Prime: ");
            num = int.Parse(Console.ReadLine());
            m = num / 2;
            for (int i = 2; i <= m; i++) //i gets incremented now i=3
            {
                if (num % i == 0) //when taken n=9 then here 1==0 means false, now second time 9/i=3 means 0==0
                {
                    Console.Write("Number is not Prime.");// second times it comes here
                    Console.Write(num % i);
                    flag = 1; //here flag becomes 1 after getting out of block it gets into if block flag==1 so false and never enter there.
                    break;
                }
                //it comes here
            }
            if (flag == 0)
                Console.Write("Number is Prime.");
                
        }
    }
}
