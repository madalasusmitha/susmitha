using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace customerrr.Models
{
    public class customer
    {
        public int id { get; set; }
        public string name { get; set; }
        public String Email { get; set; }
        public int Amount { get; set; }
        public customer()
        {

        }
        public customer(int id, string name, string Email, int Amount)
        {
            this.id = id;
            this.name = name;
            this.Email = Email;
            this.Amount = Amount;

        }
    }
}
    
    

