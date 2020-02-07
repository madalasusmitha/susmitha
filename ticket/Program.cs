using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ticket
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the name of passenger");
            string name = Console.ReadLine();
            Console.WriteLine("enter the age of passenger");
            int age = int.Parse(Console.ReadLine());
            Console.WriteLine("enter the no of tickets");
            int nooftickets = int.Parse(Console.ReadLine());

            passenger p = new passenger(name, age);
            Text t = new Text(nooftickets);
            t.ticketboking(name, age, nooftickets);
            try
            {
                if (nooftickets > 2) throw new userException("cant book");
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            Console.ReadKey();
        }

    }
}
