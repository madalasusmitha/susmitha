using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the buyer name");
            string name = Console.ReadLine();
            Console.WriteLine("enter the buyer phoneno");
            double phoneno = double.Parse(Console.ReadLine());
            Console.WriteLine("enter the mail");
            string mail = Console.ReadLine();
            Console.WriteLine("enter the buyer address");
            string address = Console.ReadLine();
            Console.WriteLine("enter the buyer id");
            int id = int.Parse(Console.ReadLine());
            

            // Buyer b = new Buyer(name, phoneno, mail, address, id);
           List<Buyer> bu = new List<Buyer>();
            bu.Add(new Buyer(name, phoneno, mail, address, id));

        foreach(var b in bu)
            {
                Console.WriteLine(b);
            }
            Console.ReadKey();
        }
    }
}
