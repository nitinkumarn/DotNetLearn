using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Arrays
{

    //input 1 2     1 3
    //      3 4     2 4
    class ArrayRowToColoumn
    {
        static void Main(string[] args)
        {
            int[,] A = new int[3, 3] { { 1, 2, 3 }, { 3, 4, 5 }, { 6, 7, 8 } };
            int[,] B = new int[3, 3];

            Console.WriteLine("Array elements Before :");
            for (int i = 0; i < A.GetLength(0); i++)
            {
                for (int j = 0; j < A.GetLength(1); j++)
                {
                    Console.Write(A[i, j] + " ");
                }
                Console.WriteLine();
            }
            for (int i = 0; i < B.GetLength(0); i++)
            {
                for (int j = 0; j < B.GetLength(1); j++)
                {
                    B[i, j] = A[j, i];
                }
            }

            Console.WriteLine("Array elements are:");
            for (int i = 0; i < B.GetLength(0); i++)
            {
                for (int j = 0; j < B.GetLength(1); j++)
                {
                    Console.Write(B[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
