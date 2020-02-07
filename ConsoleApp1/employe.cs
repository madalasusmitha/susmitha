using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class employe
    {
        int empid;
        string name;
        string des;
        public employe(int empid,string name,string des)
        {
            this.Des = des;
            this.Empid = empid;
            this.Name = name;
        }

        public int Empid { get => empid; set => empid = value; }
        public string Name { get => name; set => name = value; }
        public string Des { get => des; set => des = value; }
    }
}
