using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Patterns
{
    class Diamond
    {
        static void Main(string[] args)
        {
            int n = 5;

            //Upper Part
            for(int i = 0; i <= n; i++)
            {
                Console.Write(new String(' ', n - i));
                for(int j = 0; j <= i; j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }

            //Lower Part
            for(int i = n; i > 0; i--)
            {
                
                Console.Write(new String(' ', n - i));
                for (int j = i; j > 0; j--)
                {
                    Console.Write(" *");
                }
                
                Console.WriteLine();

            }
        }
    }
}
