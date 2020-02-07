using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;


namespace emas.Models
{
    public class Validatedomain:ValidationAttribute
    {
        public readonly string allowDomain;
        public Validatedomain(string allowdomain)
        {
            this.allowDomain = allowdomain;
        }
        public override bool IsValid(object value)
        {
            string[] email = value.ToString().Split('@');
            if (email[1] == this.allowDomain)
                return true;
            else
                return false;

           
        }
    }
}
