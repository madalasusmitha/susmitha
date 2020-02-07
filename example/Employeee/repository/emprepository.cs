using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Employeee.Models;

namespace Employeee.repository
{
    public class emprepository
    {
        public static List<Emoloye> list = new List<Emoloye>()
        {
            new Emoloye(){
                eid="2334",
               name = "susmitha",
               des="manager",
               pname=".net",
               pwd="2345"

                }

        };
        public emprepository()
        {

        }
        public void Add(Emoloye item)
        {
            list.Add(item);

        }
        public Emoloye validate(string Eid, string pass)
        {
            foreach (var item in list)
            {
                if (item.eid == Eid && item.pwd == pass)
                {
                    return item;
                }
            }
            return null;
        }
    }
}
