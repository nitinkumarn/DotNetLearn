using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Patterns
{
    class RightAllignedTriangle
    {
        static void Main(string[] args)
        {
            int n= 5;
            for(int i = 0; i < n; i++)
            {
                Console.Write(new String(' ', n - i));
                for(int j = 0; j <= i; j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
        }
    }
}
