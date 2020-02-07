using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            int flag = 0;
            string[] name = new string[5] 
            { "smitha", "tulasi", "madhu", "jyo", "hamsi" };
            string m = Console.ReadLine();
            foreach (string i in name)
            {


                if (m == i)
                {
                    flag = 1;
                    break;
                }
            }
            if (flag == 0)
            {

                Console.WriteLine("present");
            
            else

                Console.WriteLine("ivalid");
                      }
            
                Console.ReadKey();

            
            }
        }
    }

