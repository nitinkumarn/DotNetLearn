using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Arrays
{
    class TwoDimensionArray
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter row size: ");
            int r = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter column size: ");
            int c = Convert.ToInt32(Console.ReadLine());

            int[,] A = new int[r, c];

            Console.WriteLine("Enter the elements:");
            for (int i = 0; i < A.GetLength(0); i++)
            {
                for (int j = 0; j < A.GetLength(1); j++)
                {
                    Console.Write($"Enter element at position [{i + 1}, {j + 1}]: ");
                    A[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            Console.WriteLine("Array elements are:");
            for (int i = 0; i < A.GetLength(0); i++)
            {
                for (int j = 0; j < A.GetLength(1); j++)
                {
                    Console.Write(A[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
