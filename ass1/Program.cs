using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ass1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter name");
            string name = Console.ReadLine();
            Console.WriteLine("enter graduation year");
            int year=int.Parse( Console.ReadLine());
            Console.WriteLine("my name is  " + name + "  and i graduated in" + year);
            Console.ReadKey();

        }
    }
}
