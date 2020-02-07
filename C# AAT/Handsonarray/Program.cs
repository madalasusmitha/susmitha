using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Handsonarray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = new int[5] { 10, 23, 30, 47, 50 };
            int sum = 0;
            foreach(int i in a)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i); 
                }
            }
        }
    }
}
