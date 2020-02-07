using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ticket
{
    class passenger
    {
       protected string name;
         protected int age;
        public passenger(string name, int age)
        {
            this.name = name;
            this.age = age;
        }
    }

        
        class Text:passenger
        {
            int nooftickets;
            public Text(int nooftickets)
            {
                this.Nooftickets = nooftickets;
            }

            public int Nooftickets { get => nooftickets; set => nooftickets = value; }

        public void ticketboking(string name, int age, int nooftickets):base(name,age)
            {
                this.name = name;
                this.age = age;
                this.nooftickets = nooftickets;
                Console.WriteLine(name + " " + age + " " + nooftickets);
            }
            
        }
        public class userException:Exception
            {
            public userException(string s):base(s)
            {

            }
    }
}
