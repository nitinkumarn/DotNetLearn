using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Arrays
{
    class SingleDimension
    {
        static void Main(string[] args)
        {
            int[] A = { 10, 20, 30 };
            foreach(int i in A)
            {
                Console.WriteLine(i);
            }


            Console.WriteLine("Enter the array size: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] B = new int[n];

            Console.WriteLine($"Enter the array elements of size {n}: ");
            for (int i=0;i<n;i++)
            {
                B[i]=Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("The Length of Array is : " + B.Length);
            Console.WriteLine("The Rank of Array is : " + B.Rank);
            Console.WriteLine("Array Elements are : ");
            foreach (int i in B)
            {
                Console.Write(i+ " ");
            }

            Console.Read();
        }
    }
}
