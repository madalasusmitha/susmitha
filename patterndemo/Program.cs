using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace patterndemo
{
    class Program
    {
        static void Main(string[] args)
        {
            singletern s1 = singletern.Getinstance;
            
            //singletern s = new singletern();
            s1.printdetails("hi");
            singletern s2 = singletern.Getinstance;
            // singletern s1 = new singletern();
            s2.printdetails("hello");

        }
    }
}
