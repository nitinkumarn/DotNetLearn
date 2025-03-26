using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class StringArray
    {
        static void Main(string[] args)
        {
            String str = "I am Nitin kumar";
            String[] s = str.Split(" ");
            Console.WriteLine(s[2]);

        }
    }
}
