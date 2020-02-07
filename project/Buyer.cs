using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project
{
    class Buyer
    {
        string name;
        double phoneno;
        string mail;
        string address;
        int id;

        public string Name { get => name; set => name = value; }
        public double Phoneno { get => phoneno; set => phoneno = value; }
        public string Mail { get => mail; set => mail = value; }
        public string Address { get => address; set => address = value; }
        public int Id { get => id; set => id = value; }
        public Buyer(string name,double  phoneno,string mail,string address,int id)
        {
            this.name = name;
            this.phoneno = phoneno;
            this.mail = mail;
            this.address = address;
             this.id = id;

        }
         
    }
}
