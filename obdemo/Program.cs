using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace obdemo
{
    class bike
    {
        string name;
        string color;
        public static void Startengine()
        { }
        public void Fillgas(int litres)
        {
            Console.WriteLine("bike is filled with litres" + litres);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            bike enfield = new bike();
            enfield.Fillgas(10);
        }
    }
}
