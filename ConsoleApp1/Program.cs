using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<employe> el = new List<employe>();
            while (true)
            {
                Console.WriteLine("Menu........................ ");
                Console.WriteLine("1.Insert Employee Details");
                Console.WriteLine("2.Display all employee details");
                Console.WriteLine("3.Update employee Details based on Id");
                Console.WriteLine("4.Delete a specific employee ");
                Console.WriteLine("5.Exit");
                Console.WriteLine("enter your choice: ");
                int ch = int.Parse(Console.ReadLine());
                int eid;
                String n, ed;
                switch (ch)
                {
                    case 1:
                        Console.WriteLine("enter employee id ,name,designation");
                        eid = int.Parse(Console.ReadLine());
                        n = Console.ReadLine();
                        ed = Console.ReadLine();

                        el.Add(new employe(eid, n, ed));
                        break;
                    case 2:
                        foreach (employe i in el)
                        {
                            Console.WriteLine(i.Empid + " " + i.Name + " " + i.Des);
                        }
                        break;
                    case 3:
                        Console.WriteLine("enter employee id:");
                        eid = int.Parse(Console.ReadLine());
                        foreach (employe i in el)
                        {
                            if (i.Empid == eid)
                            {
                                Console.WriteLine("enter employee name,designation to change:");
                                n = Console.ReadLine();
                                ed = Console.ReadLine();
                                i.Name = n;
                                i.Des= ed;
                            }
                        }

                        break;
                    case 4:
                        Console.WriteLine("enter employee id:");
                        eid = int.Parse(Console.ReadLine());
                        foreach (employe i in el)
                        {
                            if (i.Empid== eid)
                            {
                                el.Remove(i);
                            }
                        }
                        break;
                    case 5:
                        Environment.Exit(0);
                        break;
                }

            }
            Console.ReadKey();

        }

    }
}
