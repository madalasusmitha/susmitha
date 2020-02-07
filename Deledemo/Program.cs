using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deledemo
{
    public delegate void delegatepointer();
    public delegate void Calareapointer(double x);
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello world");
            //delegatepointer mydelegate = new delegatepointer(print);
            Program p = new Program();
            delegatepointer mydelegate = p.print;
            mydelegate += p.display;
            mydelegate();

            Calareapointer cptr = calculate.calarea;
            double area = cptr(20);
            Console.WriteLine(area);
          

        }
        public void print()
        {
            Console.WriteLine("welcome to deligate");
        }
        public void display()
        {
            Console.WriteLine("welcome to multicast deligate");
        }
    }
}
