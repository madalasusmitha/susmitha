using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stud
{
    class Program
    {
        static void Main(string[] args)
        {
            ug u = new ug("susmitha", "345", 89);
            pg p= new pg("swathi", "45", 70);
            u.Ispassed(89);
            p.Ispassed(70);
                
            Console.ReadKey();
        }
    }
}
