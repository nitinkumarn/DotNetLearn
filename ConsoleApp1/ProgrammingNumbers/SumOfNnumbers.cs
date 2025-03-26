using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class SumOfNnumbers
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number : ");
           int n =  Convert.ToInt32(Console.ReadLine());
            int sum = 0;
            for(int i = 0; i <= n; i++)
            {
                sum = sum + i;
            }
            Console.WriteLine($"The sum upto {n} number is : {sum}");
        }
    }
}
