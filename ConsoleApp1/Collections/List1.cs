using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Collections
{
    class List1
    {
        static void Main(string[] args)
        {
            List<String> li = new List<string> {"Bangalore","Chennai","Mumbai","Delhi"};

            int index = li.IndexOf("Chennai");

            if (index != -1)
            {
                li[index] = "Pune";
            }
            else
            {
                throw new Exception("Element not present ");
            }
            Console.WriteLine("The replaced city list are: ");
            foreach (String s in li)
            {
                
                Console.WriteLine(s);
            }

            
            
            
        }
    }
}
