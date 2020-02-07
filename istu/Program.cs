using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace istu
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("dayscholar");
            string name = Console.ReadLine();
            int id = int.Parse(Console.ReadLine());
            dayscholar d = new dayscholar(name, id);
            d.display();

            
            Console.WriteLine("resident");
            string name1 = Console.ReadLine();
            int id1 = int.Parse(Console.ReadLine());
           presedient p = new presedient(name1, id1);
            p.display();

        }
    }
}
