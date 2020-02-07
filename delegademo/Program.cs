using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace delegademo
{
    public delegate double calareapointer(double x);
    class Program
    {

        static void Main(string[] args)
        {
            calareapointer cptr = new calareapointer(calarea);
            double area = cptr(12);
            Console.WriteLine(area);
            Console.ReadKey();
                
        }
        public static double calarea(double r)
        {
            return 3.14 * r * r;
        }
    }
}
