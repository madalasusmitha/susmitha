using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace istu
{
    public interface istudent
    {
        string name {get;set;}
        int id { get; set; }

        
         void display();
    }
    class dayscholar : istudent
    {
        int id;
        string name;
        int istudent.id { get { return id; } set { id = value; } }
        string istudent.name { get { return name; } set { name = value; } }
        public dayscholar(string name,
            
            int id)
        {
            this.name = name;
            this.id = id;

        }
        public void display()
        {
            Console.WriteLine(this.id + " " + this.name);
        }

    }


    class presedient:istudent
    {
        int id;
        string name;
        int istudent.id { get { return id; } set { id = value; } }
        string istudent.name { get { return name; }set { name = value; } }
        public presedient(string name,int id)
        {
            this.name = name;
            this.id = id;

        }
        public void display()
        {
            Console.WriteLine(this.id + " " + this.name);
        }
        
    }
}
