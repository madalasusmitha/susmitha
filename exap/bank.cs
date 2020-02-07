using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exap
{
    interface Iloan
    {
        void getinterest();
    }
     public  abstract class Bank
    {
         protected string name;
        protected string location;
        public Bank(string name,string location)
        {
            this.name = name;
            this.location = location;

        }
       
             
    }
    public class SBI:Bank,Iloan
    {
        string manager;
        public SBI(string name,string location,string manager):base(name,location)
        {
            this.manager = manager;
        }
        public void getinterest()
        {
            Console.WriteLine("sbi interest is 5%");
        }
        public void Displaydetails()
        {
            Console.WriteLine(this.name + " " + this.location + " " + this.manager);
        }

    }
    public class ICICI:Bank,Iloan
    {
        string head;
        public ICICI(string name,string location,string head):base(name,location)
        {
            this.head = head;

        }
        public void Displaydetails()
        {
            Console.WriteLine(this.name + " " + this.location + " " + this.head);
        }
        public void getinterest()
        {
            Console.WriteLine("sbi interest is 12%");

        }
    }
}
