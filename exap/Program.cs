using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exap
{
    class Program
    {
        static void Main(string[] args)
        {
            // cricketplayer cp = new cricketplayer("susmitha","delhi",7,6,8);

            // cp.DisplayPlayerstatistic();
            // Hockeyplayer hk = new Hockeyplayer("swathi","mombay",8,"captian" , 7);
            // hk.DisplayPlayerstatistic();
            // Console.ReadKey();
            SBI sb = new SBI("susmitha", "chennai", "huj");
            ICICI ic = new ICICI("swathi", "hyd", "ghj");
            sb.Displaydetails();
            sb.getinterest();
            ic.Displaydetails();
            ic.getinterest();

        }
    }
}
