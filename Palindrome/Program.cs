using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindrome
{
    class Program
    {
        static void Main(string[] args)
        {
            int num, revnum,temp, sum=0;
            Console.WriteLine("Enter Number");
            num = Convert.ToInt32(Console.ReadLine());
            temp = num;
            while (num > 0)
            {
                //revnum = num % 10;
                //sum = (sum * 10) + revnum; //Palindrome
                //num = num / 10;

                revnum = num % 10;
                sum = sum + (revnum * revnum * revnum); //Armstrong Ex371=3*3*3+7*7*7+1*1*1=371
                num = num / 10;
            }
            Console.WriteLine("Value of Sum:"+sum);
            Console.WriteLine("Value of num:"+num);
            Console.WriteLine("Value of temp:" + temp);
            if (temp==sum)
            {
                Console.WriteLine();
                //Console.WriteLine("Number is Palindrom");
                Console.WriteLine("Number is Armstrong");
            }
            else
            {
                //Console.WriteLine("Not Palindrome");
                Console.WriteLine("Not Armstrong");
            }
        }
    }
}
