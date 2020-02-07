using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dateda
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime d1 = DateTime.Now;
            Console.WriteLine(d1.Day);
            Console.WriteLine(d1.Year);
            Console.WriteLine(d1.Month);
            Console.WriteLine(d1.AddDays(20));
            d1 = DateTime.Parse(Console.ReadLine());
            d1= DateTime.ParseExact(Console.ReadLine(),"dd/mm/yy",null);

            Console.ReadKey();

        }
    }
}
