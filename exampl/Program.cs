using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exampl
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter no of trainee");
            int n = int.Parse(Console.ReadLine());
            List<trainee> t = new List<trainee>();
            for(int i=0;i<n;i++)
            {
                Console.WriteLine("enter trainee id,name,projectid");
                int tid = int.Parse(Console.ReadLine());
                string name = Console.ReadLine();
                int projectid = int.Parse(Console.ReadLine());
                t.Add(new trainee(tid, name, projectid));

            }
            List<trainee> p = t.FindAll(e => e.projectid != -1);
                foreach(trainee t1 in p)
            {
                Console.WriteLine(t1.ToString());
            }
            Console.ReadLine();

        }
    }
}
