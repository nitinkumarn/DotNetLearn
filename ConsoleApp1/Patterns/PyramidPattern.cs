using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Patterns
{
    class PyramidPattern
    {
        static void Main(string[] args)
        {
            int n = 5;
            for(int i = 0; i < n; i++)
            {
                Console.Write(new String(' ', n - i-1));
                for(int j = 0; j < 2*i+1; j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
        }
    }
}
