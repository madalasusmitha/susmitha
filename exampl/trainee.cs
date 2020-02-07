using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exampl
{
    class trainee
    {
       public int id;
         protected string name;
       public int projectid;

        public trainee(int id,string name,int projectid)
        {
            this.id = id;
            this.name = name;
            this.projectid = projectid;
        }
        public override string ToString()
        {
            return this.name;
        }
    }
}
